namespace KRtDL_Level_Randomizer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string path = Application.StartupPath + $"{Path.DirectorySeparatorChar}save.bin";
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(0, SeekOrigin.Begin);
                int i = fs.ReadByte();

                if(i == -1)
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.WriteByte(1);
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);

                    MessageBox.Show("Thank you for downloading this KRtDL level randomizer! Just a heads up before you proceed : this program will directly mess with your KRtDL level files! Be careful with what you're doing and don't do stuff that you would regret. Alright enjoy!", "Hold up!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}