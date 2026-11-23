namespace OOP_TEAM_PROJECT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());   // admin login is the startup form
        }
    }
}
