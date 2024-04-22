using ApplicationManager.Helpers;
using Authorize.WinForm;
using Core.Constants.DefaultValues;
using Core.Constants.Enums;
using Core.CustomException;
using Core.Dto;
using Core.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NovaPostOrderManager.Forms;
using Serilog;
using Serilog.Events;
using System.Reflection;
using System.Xml.Linq;

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
            UpdateProjectVersion(Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? throw new CustomException("Version not set"));
            Task.Run(SettingsManager.CopyAndUpdateSettings).Wait();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IConfiguration configurationSetting = new ConfigurationBuilder()
              .AddJsonFile("UserSetting\\settings.json", optional: true, reloadOnChange: true)
              .Build();

            var configuration = ConfigurationHelper.GetEmbeddedConfiguration("NovaPostOrderManager.appsettings.json", Assembly.GetExecutingAssembly());
            ConfigurationServer();
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration).WriteTo.Console()
                .WriteTo.File(
                    configuration["LogPath"],
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                    rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();

            Log.Logger = logger;
            CoreDefaultValues.ApiKey = configurationSetting["ApiKey"];
            CoreDefaultValues.AddressApteka = configurationSetting.GetSection("UserData:Address").Value ?? "";
            CoreDefaultValues.ContactApteka = configurationSetting.GetSection("UserData:Contact").Value ?? "";
            CoreDefaultValues.PhoneApteka = configurationSetting.GetSection("UserData:Phone").Value ?? "";
            CoreDefaultValues.Server = configurationSetting["Server"];

            CoreDefaultValues.Password = configuration["SettingDatabase:Password"];
            CoreDefaultValues.User = configuration["SettingDatabase:User"];


            Application.ThreadException += (sender, args) => GlobalExceptionHandler(args.Exception);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => GlobalExceptionHandler(args.ExceptionObject as Exception);
            ApplicationConfiguration.Initialize();

            var formAuthorize = new FormAuthorize();
            var result = formAuthorize.ShowDialog();

            if (result == DialogResult.OK)
            {
                formAuthorize.Dispose();
                Application.Run(new MainForm());
            }


        }
        public static void UpdateProjectVersion(string version, string configFilename = "Config.json")
        {
            // Путь к файлу конфигурации
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), configFilename);

            // Проверка на существование файла
            if (!File.Exists(configPath))
            {
                return;
            }

            // Чтение и десериализация файла конфигурации
            var configText = File.ReadAllText(configPath);
            var config = JsonConvert.DeserializeObject<Config>(configText);

            if (config == null)
            {
                Console.WriteLine("Не удалось десериализовать файл конфигурации.");
                return;
            }

            // Обновление версии
            config.Version = CoreDefaultValues.Version = version;

            // Сериализация и запись обновленной конфигурации обратно в файл
            var updatedConfigText = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(configPath, updatedConfigText);

            Console.WriteLine($"Версия проекта обновлена до {version} в файле {configFilename}.");
        }

        public static void GlobalExceptionHandler(Exception e)
        {
            var errorInfo = ProcessException(e);

            MessageBox.Show($"" +
                            $"Помилка: {errorInfo.Message}\n" +
                            $"Тип: {errorInfo.Type}\n", "Тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Log.Logger.Error(e, e.Message);

        }
        private static ErrorInfo ProcessException(Exception ex)
        {
            switch (ex)
            {
                case CustomException customException:
                    return new ErrorInfo
                    {
                        Type = customException.ErrorType,
                        Message = customException.Message,
                    };
                case BadRequestException badRequestException:
                    return new ErrorInfo
                    {
                        Type = badRequestException.ErrorType,
                        Message = badRequestException.Message,
                    };
                case LoginFailedException loginFailedException:
                    return new ErrorInfo
                    {
                        Type = loginFailedException.ErrorType,
                        Message = loginFailedException.Message,
                    };
                case AlivePasswordFailedException alivePasswordFailedException:
                    return new ErrorInfo
                    {
                        Type = alivePasswordFailedException.ErrorType,
                        Message = alivePasswordFailedException.Message,
                    };
                case AuthorizeException authorizeException:
                    return new ErrorInfo
                    {
                        Type = authorizeException.ErrorType,
                        Message = authorizeException.Message,
                    };
                default:
                    return new ErrorInfo
                    {
                        Type = ErrorType.General,
                        Message = ex.Message,
                    };
            }
        }

        private static async void ConfigurationServer()
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var settingsPath = Path.Combine(exeDirectory, CoreDefaultValues.PathUserSetting);
            var xmlConfigPath = @"C:\WinService\WinServiceConfig.xml";

            // Проверка существования settings.json, если не существует, создать с базовым содержимым
            if (!File.Exists(settingsPath))
            {
                var baseSettings = new Settings
                {
                    ApiKey = "",
                    Server = "",
                    UserData = new UserData
                    {
                        Contact = "",
                        Address = "",
                        Phone = ""
                    }
                };
                string baseJson = JsonConvert.SerializeObject(baseSettings, Formatting.Indented);
                await File.WriteAllTextAsync(settingsPath, baseJson);
            }

            var xml = XDocument.Load(xmlConfigPath);
            var sqlServerValue = xml.Element("config")?.Element("sqlServer")?.Value;

            if (!string.IsNullOrEmpty(sqlServerValue))
            {
                var json = await File.ReadAllTextAsync(settingsPath);
                var settings = JsonConvert.DeserializeObject<Settings>(json);


                settings.Server = sqlServerValue;

                // Запись обновленного JSON обратно в файл
                string output = JsonConvert.SerializeObject(settings, Formatting.Indented);
                await File.WriteAllTextAsync(settingsPath, output);
            }
        }
    }
}
