using ApplicationManager.Services.NovaPostService;
using Core.Model;
using Newtonsoft.Json;

namespace ApplicationManager.Services.SupportService
{
    public class VersionChecker
    {
        public delegate void VersionMismatchEventHandler(object sender, EventArgs e);
        public event VersionMismatchEventHandler VersionMismatch;
        private Config _localConfig;
        private Config _remoteConfig;
        private Timer _timer;

        public VersionChecker()
        {
            _localConfig = LoadLocalConfig();
        }

        public void StartChecking()
        {
            _timer = new Timer(async _ =>
            {
                await CheckVersionAsync();
            }, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
        }
        private Config LoadLocalConfig()
        {
            var localConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.json");
            var configJson = File.ReadAllText(localConfigPath);
            return JsonConvert.DeserializeObject<Config>(configJson);
        }
        private async Task CheckVersionAsync()
        {
            try
            {
                var clientProvider = new HttpClientProvider(_localConfig.RemotePath ?? throw new Exception("В конфігурації немає мережевого шляху для завантаження файлів"));

                _remoteConfig = await clientProvider.DownloadAsync<Config>("Config.json");

                if (_localConfig.Version != _remoteConfig.Version)
                {
                    VersionMismatch?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при перевірці версії: {ex.Message}");
            }
        }

        public void StopChecking()
        {
            _timer?.Change(Timeout.Infinite, 0);
        }
    }
}