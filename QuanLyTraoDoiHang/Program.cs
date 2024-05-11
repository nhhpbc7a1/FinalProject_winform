using System.Security.Policy;

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

        public static int currentUserId = -1;

        public static User CurrentUser() { return UserDAO.SelectByUserId(currentUserId); }

        public static Image TakeRandom()
        {
             List<Image> listImage = new List<Image>()
            {
                Properties.Resources.GPX_LEGEND_150_S__202I_chính_chủ_xe_classic_pkl___1,
                Properties.Resources.Ip15_2,
                Properties.Resources.pro1_1,
                Properties.Resources.Mitsubishi_1,
                Properties.Resources.Máy_in_màu_Epson_L120_4màu_sắc_nét_cực_căng_đẹp____2,
                Properties.Resources.omega_seamaster_3,
                Properties.Resources.poddle_4,
                Properties.Resources.pro1_4,
                Properties.Resources.pro3_2,
                Properties.Resources.pro5_2,
                Properties.Resources.samsung_A14_5g
            };



            try
            {
                Random random = new Random();
                int x = listImage.Count;
                int i = random.Next(x);

                if (i == 0)
                    return Properties.Resources.empty_product;
                return listImage[i];
            }
            catch
            {
                return Properties.Resources.empty_product;
            }
            return Properties.Resources.empty_product;
        }
    }
}