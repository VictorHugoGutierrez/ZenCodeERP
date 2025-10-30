using ZenCodeERP.Forms;

namespace ZenCodeERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MDILogin loginForm = new MDILogin();

            DialogResult dialogResult = loginForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Application.Run(new MDIPrincipal());
            }
        }
    }
}