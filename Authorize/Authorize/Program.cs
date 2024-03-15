using Authorize.WinForm;
using AuthorizeCore.Constants.Enums;
using AuthorizeCore.CustomException;
using AuthorizeCore.Model;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using System.Reflection;

namespace Authorize
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var assembly = Assembly.GetExecutingAssembly();
            var builder = new ConfigurationBuilder();

            Stream? stream = assembly.GetManifestResourceStream("Authorize.setting.json");
            if (stream == null)
            {
                throw new InvalidOperationException("Could not find embedded resource");
            }

            builder.AddJsonStream(stream);

           var configuration = builder.Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration).WriteTo.Console()
                .WriteTo.File(
                    configuration["LogPath"],
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                    rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();
            Log.Logger = logger;
            Application.ThreadException += (sender, args) => GlobalExceptionHandler(args.Exception);

            AppDomain.CurrentDomain.UnhandledException += (sender, args) => GlobalExceptionHandler(args.ExceptionObject as Exception);

            Application.Run(new FormAuthorize());
        }
        public static void GlobalExceptionHandler(Exception e)
        {
            ErrorInfo errorInfo = ProcessException(e);

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
                case LivePasswordFailedException livePasswordFailedException:
                    return new ErrorInfo
                    {
                        Type = livePasswordFailedException.ErrorType,
                        Message = livePasswordFailedException.Message,
                    };
                default:
                    return new ErrorInfo
                    {
                        Type = ErrorType.General,
                        Message = ex.Message,
                    };
            }
        }
    }
}