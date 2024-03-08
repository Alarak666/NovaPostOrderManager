using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ApplicationManager.Helpers;

public static class ConfigurationHelper
{
    public static IConfiguration GetEmbeddedConfiguration(string resourceName, Assembly assembly)
    {
        var builder = new ConfigurationBuilder();
    
        var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null) throw new InvalidOperationException("Could not find embedded resource");

        builder.AddJsonStream(stream);

        return builder.Build();
    }
}