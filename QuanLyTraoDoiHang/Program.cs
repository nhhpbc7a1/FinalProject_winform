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
        public static List<Voucher> listVoucher = new List<Voucher>()
        {
            new Voucher("fashion","1",Convert.ToDateTime("10/12/2024"), 20, 100),
            new Voucher("fashion", "2", Convert.ToDateTime("12/12/2024"), 10, 50),
            new Voucher("travel","3",Convert.ToDateTime("7/25/2024"), 40, 20),
            new Voucher("KoHa","4",Convert.ToDateTime("12/09/2024"), 6, 60),
            new Voucher("KoHa","5",Convert.ToDateTime("12/11/2024"), 30, 90)

        };

        public static Mainpage mainpage = new Mainpage();
        public static int currentUserId = 2  ;
        public static User CurrentUser() { return UserDAO.SelectByUserId(currentUserId); }
    }
}