namespace ScreenTinter
{
    partial class ScreenTinter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenTinter));
            this.panelMain = new System.Windows.Forms.Panel();
            this.checkBoxTopMost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.buttonBindKey = new Guna.UI2.WinForms.Guna2Button();
            this.Image = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonCopy = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxHRH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTextColor_HSL = new System.Windows.Forms.Label();
            this.labelTextColor_HEX = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTextColor_RGB = new System.Windows.Forms.Label();
            this.timerPixel = new System.Windows.Forms.Timer(this.components);
            this.panelDrag = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelDrag);
            this.panelMain.Controls.Add(this.checkBoxTopMost);
            this.panelMain.Controls.Add(this.guna2TrackBar1);
            this.panelMain.Controls.Add(this.buttonBindKey);
            this.panelMain.Controls.Add(this.Image);
            this.panelMain.Controls.Add(this.buttonCopy);
            this.panelMain.Controls.Add(this.comboBoxHRH);
            this.panelMain.Controls.Add(this.labelTextColor_HSL);
            this.panelMain.Controls.Add(this.labelTextColor_HEX);
            this.panelMain.Controls.Add(this.pictureBoxColor);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.labelTextColor_RGB);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(417, 259);
            this.panelMain.TabIndex = 0;
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.CheckedState.BorderColor = System.Drawing.Color.Gray;
            this.checkBoxTopMost.CheckedState.BorderRadius = 0;
            this.checkBoxTopMost.CheckedState.BorderThickness = 0;
            this.checkBoxTopMost.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxTopMost.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxTopMost.Location = new System.Drawing.Point(259, 180);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(68, 17);
            this.checkBoxTopMost.TabIndex = 15;
            this.checkBoxTopMost.Text = "TopMost";
            this.checkBoxTopMost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxTopMost.UncheckedState.BorderRadius = 0;
            this.checkBoxTopMost.UncheckedState.BorderThickness = 0;
            this.checkBoxTopMost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.DisplayFocus = true;
            this.guna2TrackBar1.IndicateFocus = true;
            this.guna2TrackBar1.Location = new System.Drawing.Point(133, 174);
            this.guna2TrackBar1.Maximum = 60;
            this.guna2TrackBar1.Minimum = 6;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(120, 23);
            this.guna2TrackBar1.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.guna2TrackBar1.TabIndex = 14;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.Gray;
            this.guna2TrackBar1.Value = 6;
            // 
            // buttonBindKey
            // 
            this.buttonBindKey.Animated = true;
            this.buttonBindKey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBindKey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBindKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBindKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBindKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.buttonBindKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBindKey.ForeColor = System.Drawing.Color.White;
            this.buttonBindKey.Location = new System.Drawing.Point(133, 203);
            this.buttonBindKey.Name = "buttonBindKey";
            this.buttonBindKey.Size = new System.Drawing.Size(120, 48);
            this.buttonBindKey.TabIndex = 13;
            this.buttonBindKey.Text = "BindKey";
            this.buttonBindKey.Click += new System.EventHandler(this.buttonBindKey_Click);
            this.buttonBindKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonBindKey_KeyUp);
            // 
            // Image
            // 
            this.Image.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Image.HoverState.ImageSize = new System.Drawing.Size(140, 140);
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.ImageOffset = new System.Drawing.Point(0, 0);
            this.Image.ImageRotate = 0F;
            this.Image.ImageSize = new System.Drawing.Size(140, 140);
            this.Image.Location = new System.Drawing.Point(8, 146);
            this.Image.Name = "Image";
            this.Image.PressedState.ImageSize = new System.Drawing.Size(140, 140);
            this.Image.Size = new System.Drawing.Size(119, 105);
            this.Image.TabIndex = 12;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Animated = true;
            this.buttonCopy.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCopy.BorderColor = System.Drawing.Color.White;
            this.buttonCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCopy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCopy.ForeColor = System.Drawing.Color.White;
            this.buttonCopy.Location = new System.Drawing.Point(256, 87);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.PressedColor = System.Drawing.Color.White;
            this.buttonCopy.Size = new System.Drawing.Size(156, 35);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy Value";
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopyValue_Click);
            // 
            // comboBoxHRH
            // 
            this.comboBoxHRH.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxHRH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.comboBoxHRH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHRH.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxHRH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxHRH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxHRH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHRH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.comboBoxHRH.ItemHeight = 30;
            this.comboBoxHRH.Items.AddRange(new object[] {
            "HEX",
            "RGB",
            "HSL"});
            this.comboBoxHRH.Location = new System.Drawing.Point(256, 45);
            this.comboBoxHRH.Name = "comboBoxHRH";
            this.comboBoxHRH.Size = new System.Drawing.Size(156, 36);
            this.comboBoxHRH.TabIndex = 8;
            // 
            // labelTextColor_HSL
            // 
            this.labelTextColor_HSL.AutoSize = true;
            this.labelTextColor_HSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.labelTextColor_HSL.Location = new System.Drawing.Point(133, 95);
            this.labelTextColor_HSL.Name = "labelTextColor_HSL";
            this.labelTextColor_HSL.Size = new System.Drawing.Size(35, 13);
            this.labelTextColor_HSL.TabIndex = 6;
            this.labelTextColor_HSL.Text = "label1";
            this.labelTextColor_HSL.Click += new System.EventHandler(this.labelTextColor_HSL_Click);
            // 
            // labelTextColor_HEX
            // 
            this.labelTextColor_HEX.AutoSize = true;
            this.labelTextColor_HEX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.labelTextColor_HEX.Location = new System.Drawing.Point(133, 72);
            this.labelTextColor_HEX.Name = "labelTextColor_HEX";
            this.labelTextColor_HEX.Size = new System.Drawing.Size(35, 13);
            this.labelTextColor_HEX.TabIndex = 5;
            this.labelTextColor_HEX.Text = "label1";
            this.labelTextColor_HEX.Click += new System.EventHandler(this.labelTextColor_HEX_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxColor.Location = new System.Drawing.Point(10, 45);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(115, 95);
            this.pictureBoxColor.TabIndex = 0;
            this.pictureBoxColor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(8, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 99);
            this.panel1.TabIndex = 4;
            // 
            // labelTextColor_RGB
            // 
            this.labelTextColor_RGB.AutoSize = true;
            this.labelTextColor_RGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.labelTextColor_RGB.Location = new System.Drawing.Point(133, 49);
            this.labelTextColor_RGB.Name = "labelTextColor_RGB";
            this.labelTextColor_RGB.Size = new System.Drawing.Size(35, 13);
            this.labelTextColor_RGB.TabIndex = 1;
            this.labelTextColor_RGB.Text = "label1";
            this.labelTextColor_RGB.Click += new System.EventHandler(this.labelTextColor_RGB_Click);
            // 
            // timerPixel
            // 
            this.timerPixel.Enabled = true;
            this.timerPixel.Interval = 10;
            this.timerPixel.Tick += new System.EventHandler(this.TimerPixel_Tick);
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.panelDrag.Controls.Add(this.guna2ControlBox2);
            this.panelDrag.Controls.Add(this.guna2ControlBox1);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(417, 37);
            this.panelDrag.TabIndex = 16;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(367, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(182)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(316, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.panelDrag;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // ScreenTinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 259);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenTinter";
            this.Text = "Screen Tinter";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Label labelTextColor_RGB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTextColor_HSL;
        private System.Windows.Forms.Label labelTextColor_HEX;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHRH;
        private Guna.UI2.WinForms.Guna2Button buttonCopy;
        private System.Windows.Forms.Timer timerPixel;
        private Guna.UI2.WinForms.Guna2ImageButton Image;
        private Guna.UI2.WinForms.Guna2Button buttonBindKey;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxTopMost;
        private System.Windows.Forms.Panel panelDrag;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}

