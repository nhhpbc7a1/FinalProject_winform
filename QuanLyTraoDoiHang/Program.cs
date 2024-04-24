namespace QuanLyTraoDoiHang
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
            Application.Run(mainpage);
        }
        public static Mainpage mainpage = new Mainpage();
        public static int currentUserId = 2;
        public static User CurrentUser() { return UserDAO.SelectByUserId(currentUserId); }
    }
}