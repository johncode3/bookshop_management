using BookShopWinFrm.BusinessLayer;

namespace BookShopWinFrm
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
            ApplicationConfiguration.Initialize();

            FrmMain mainForm = new FrmMain();
            using (FrmLogin loginForm = new FrmLogin(mainForm))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(mainForm);
                }
            }
        }
    }
}