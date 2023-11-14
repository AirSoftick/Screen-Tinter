using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ScreenTinter
{
    public partial class ScreenTinter : Form
    {
        private bool isProcessRunning = false;
        private Thread processThread;
        public string pth = null;

        private bool keyDown = false;
        private bool timerActive = true;

        #region DLLs
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        #endregion


        public ScreenTinter()
        {
            InitializeComponent();
            Image.Paint += PictureBoxPixel_Paint;

            StartProcess();

            try
            {
                string settingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "ScreenTinter", "settings.txt");
                if (File.Exists(settingsFilePath))
                {
                    string[] lines = File.ReadAllLines(settingsFilePath);
                    if (lines.Length > 0)
                    {
                        pth = lines[0];
                        buttonBindKey.Text = pth;
                    }
                }
                else
                {
                    MessageBox.Show("Error: File not found", "Ooops");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error: File read error", "Ooops");
                this.Close();
            }
        }

        private void TimerPixel_Tick(object sender, EventArgs e)
        {
            if (!timerActive)
                return;

            Point cursorPos = Cursor.Position;
            int originalCaptureSize = guna2TrackBar1.Value;
            Bitmap originalScreenPixel = new Bitmap(originalCaptureSize, originalCaptureSize);
            using (Graphics g = Graphics.FromImage(originalScreenPixel))
            {
                g.CopyFromScreen(cursorPos.X - originalCaptureSize / 2, cursorPos.Y - originalCaptureSize / 2, 0, 0, originalScreenPixel.Size);
            }
            Bitmap resizedScreenPixel = ResizeImageWithoutStretch(originalScreenPixel, originalCaptureSize, originalCaptureSize);
            Image.Image = ResizeImage(resizedScreenPixel, 140, 140);

            Color pixelColor = resizedScreenPixel.GetPixel(originalCaptureSize / 2, originalCaptureSize / 2);
            labelTextColor_RGB.Text = "RGB: " + pixelColor.R + ", " + pixelColor.G + ", " + pixelColor.B;
            pictureBoxColor.BackColor = pixelColor;

            string hex = ColorToHex(pixelColor);
            labelTextColor_HEX.Text = "HEX: " + hex;

            string hsl = ColorToHSL(pixelColor);
            labelTextColor_HSL.Text = "HSL: " + hsl;
        }

        private Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

        private Bitmap ResizeImageWithoutStretch(Bitmap image, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(image, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }
            return newImage;
        }

        private void PictureBoxPixel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = Image.Width / 2;
            int centerY = Image.Height / 2;

            e.Graphics.DrawLine(Pens.Red, 0, centerY, Image.Width, centerY);
            e.Graphics.DrawLine(Pens.Red, centerX, 0, centerX, Image.Height);
        }

        private string ColorToHex(Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
        }

        private string ColorToHSL(Color color)
        {
            float h, s, l;
            RGBToHSL(color.R, color.G, color.B, out h, out s, out l);
            return string.Format("{0}%, {1}%, {2}%", Math.Round(h), Math.Round(s * 100), Math.Round(l * 100));
        }

        private void RGBToHSL(int r, int g, int b, out float h, out float s, out float l)
        {
            float rf = r / 255.0f;
            float gf = g / 255.0f;
            float bf = b / 255.0f;

            float cmax = Math.Max(rf, Math.Max(gf, bf));
            float cmin = Math.Min(rf, Math.Min(gf, bf));
            float delta = cmax - cmin;

            l = (cmax + cmin) / 2;

            if (delta == 0)
            {
                s = 0;
            }
            else
            {
                s = delta / (1 - Math.Abs(2 * l - 1));
            }

            if (delta == 0)
            {
                h = 0;
            }
            else if (cmax == rf)
            {
                h = 60 * ((gf - bf) / delta % 6);
            }
            else if (cmax == gf)
            {
                h = 60 * ((bf - rf) / delta + 2);
            }
            else
            {
                h = 60 * ((rf - gf) / delta + 4);
            }
        }

        private void labelTextColor_RGB_Click(object sender, EventArgs e)
        {
            string[] parts = labelTextColor_RGB.Text.Split(':');
            Clipboard.SetText(parts[1].Trim());
        }

        private void labelTextColor_HEX_Click(object sender, EventArgs e)
        {
            string[] parts = labelTextColor_HEX.Text.Split(':');
            Clipboard.SetText(parts[1].Trim());
        }

        private void labelTextColor_HSL_Click(object sender, EventArgs e)
        {
            string[] parts = labelTextColor_HSL.Text.Split(':');
            Clipboard.SetText(parts[1].Trim());
        }

        private void buttonCopyValue_Click(object sender, EventArgs e)
        {
            if (comboBoxHRH.SelectedItem != null)
            {
                string selectedItem = comboBoxHRH.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "HSL":
                        string[] partsHSL = labelTextColor_HSL.Text.Split(':');
                        Clipboard.SetText(partsHSL[1].Trim());
                        break;
                    case "HEX":
                        string[] partsHEX = labelTextColor_HEX.Text.Split(':');
                        Clipboard.SetText(partsHEX[1].Trim());
                        break;
                    case "RGB":
                        string[] partsRGB = labelTextColor_RGB.Text.Split(':');
                        Clipboard.SetText(partsRGB[1].Trim());
                        break;
                    default:
                        MessageBox.Show("Выберите значение из выпадающего списка.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из выпадающего списка.");
            }
        }

        private void StartProcess()
        {
            processThread = new Thread(ProcessLoop);
            processThread.Start();

            isProcessRunning = true;
        }

        private void StopProcess()
        {

            if (processThread != null && processThread.IsAlive)
            {
                processThread.Abort();
            }

            isProcessRunning = false;
        }

        private void buttonBindKey_Click(object sender, EventArgs e)
        {
            buttonBindKey.Text = "<Key>";
            StopProcess();
        }

        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTopMost.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void buttonBindKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (buttonBindKey.Text == "<Key>")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    buttonBindKey.Text = "ClickBind";
                }
                else
                {
                    buttonBindKey.Text = e.KeyCode.ToString();
                }

                try
                {
                    RenameKey("D0", "0");
                    RenameKey("D1", "1");
                    RenameKey("D2", "2");
                    RenameKey("D3", "3");
                    RenameKey("D4", "4");
                    RenameKey("D5", "5");
                    RenameKey("D6", "6");
                    RenameKey("D7", "7");
                    RenameKey("D8", "8");
                    RenameKey("D9", "9");
                    RenameKey("ShiftKey", "Shift");
                    RenameKey("Menu", "Alt");
                    RenameKey("Back", "Delete");
                    RenameKey("Oem5", @"\");
                    RenameKey("Return", "Enter");
                    RenameKey("Capital", "CapsLock");
                    RenameKey("ControlKey", "Ctrl");
                    RenameKey("OemQuestion", "/");
                    RenameKey("Oemplus", "+");
                    RenameKey("OemMinus", "-");
                    RenameKey("OemOpenBrackets", "[");
                    RenameKey("Oem6", "]");
                    RenameKey("Oem1", "*no bind key *");
                    RenameKey("Oem7", "'");
                    RenameKey("Oemcomma", ",");
                    RenameKey("OemPeriod", ".");
                }
                catch { }

                StartProcess();

                try
                {
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "ScreenTinter", "Settings.txt");
                    string st = buttonBindKey.Text;

                    using (FileStream fileStream = File.Open(filePath, FileMode.Create))
                    {
                        using (StreamWriter output = new StreamWriter(fileStream))
                        {
                            output.Write(st);
                        }
                    }
                }
                catch { }
            }
        }

        private void RenameKey(string text, string replaceText)
        {
            if (buttonBindKey.Text == text)
            {
                buttonBindKey.Text = replaceText;
                StartProcess();
            }
        }

        public static KeysConverter keyConverter = new KeysConverter();

        private void ProcessLoop()
        {
            while (true)
            {
                if (buttonBindKey.Text != "<Key>")
                {
                    try
                    {
                        Keys key = (Keys)keyConverter.ConvertFromString(buttonBindKey.Text);

                        if (GetAsyncKeyState(key) < 0 && !keyDown)
                        {
                            keyDown = true;

                            timerActive = !timerActive;

                        }
                        else if (GetAsyncKeyState(key) >= 0 && keyDown)
                        {
                            keyDown = false;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }
    }
}