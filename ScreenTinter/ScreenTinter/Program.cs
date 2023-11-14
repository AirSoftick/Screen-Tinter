using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTinter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            InitializeSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenTinter());
        }

        private static void InitializeSettings()
        {
            string settingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AirSoftick", "ScreenTinter", "settings.txt");

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(settingsFilePath));
                if (!File.Exists(settingsFilePath))
                {
                    using (StreamWriter output = File.CreateText(settingsFilePath))
                    {
                        output.Write("Bind");
                    }
                }
            }
            catch { }
        }
    }
}
