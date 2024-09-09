using CompanyDB.Views;
using CompanyDB.Presenters;
using System.Configuration;

namespace CompanyDB
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();            
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}