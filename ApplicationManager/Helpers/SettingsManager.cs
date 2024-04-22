using Core.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApplicationManager.Helpers;

public class SettingsManager
{
    private static readonly string _sourcePath = "settings.json";
    private static readonly string _destinationPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\UserSetting\\settings.json";

    public static async Task CopyAndUpdateSettings()
    {
        var currentConfig = new ConfigurationBuilder()
            .AddJsonFile(_sourcePath, optional: true, reloadOnChange: true)
            .Build();

        var currentSettings = JObject.Parse(JsonConvert.SerializeObject(currentConfig.Get<Settings>()));

        JObject previousSettings;
        if (File.Exists(_destinationPath))
        {
            previousSettings = JObject.Parse(await File.ReadAllTextAsync(_destinationPath));
            UpdateJson(previousSettings, currentSettings);
        }
        else
        {
            previousSettings = currentSettings;
        }
        string directoryPath = Path.GetDirectoryName(_destinationPath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        await File.WriteAllTextAsync(_destinationPath, previousSettings.ToString());
    }

    private static void UpdateJson(JObject previousSettings, JObject currentSettings)
    {
        // Добавляем или обновляем значения в previousSettings из currentSettings
        foreach (var property in currentSettings.Properties())
        {
            JToken oldToken;
            if (previousSettings.TryGetValue(property.Name, out oldToken))
            {
                if (oldToken.Type == JTokenType.Object && property.Value.Type == JTokenType.Object)
                {
                    UpdateJson((JObject)oldToken, (JObject)property.Value);
                }
            }
            else
            {
                previousSettings.Add(property.Name, property.Value.DeepClone());
            }
        }

        // Удаляем свойства из previousSettings, которых нет в currentSettings
        List<string> propertiesToRemove = new List<string>();
        foreach (var property in previousSettings.Properties())
        {
            if (!currentSettings.ContainsKey(property.Name))
            {
                propertiesToRemove.Add(property.Name);
            }
        }

        foreach (var propName in propertiesToRemove)
        {
            previousSettings.Remove(propName);
        }
    }

}