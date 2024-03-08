using ApplicationManager.Helpers;
using Core.Constants;
using NovaPostOrderManager.Forms;
using System.Reflection;

namespace NovaPostOrderManager
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var configuration = ConfigurationHelper.GetEmbeddedConfiguration("NovaPostOrderManager.appsetting.json", Assembly.GetExecutingAssembly());
            CoreDefaultValues.ApiKey = configuration["ApiKey"];
            CoreDefaultValues.Password = configuration["SettingDatabase:Password"];
            CoreDefaultValues.Server = configuration["SettingDatabase:Server"];
            CoreDefaultValues.User = configuration["SettingDatabase:User"];

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}