namespace Sudoku
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Con = "server=127.0.0.1;uid=root;pwd=phatbaoan112;database=sudoku";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDangNhap(Con));
        }
    }
}