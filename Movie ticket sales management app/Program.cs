



using Movie_ticket_sales_management_app.GUI;

namespace Movie_ticket_sales_management_app
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new frmQLDangNhap());



        }
    }
}