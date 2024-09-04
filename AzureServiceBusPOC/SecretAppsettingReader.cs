using Microsoft.Extensions.Configuration;

namespace AzureServicebusPOC
{

    public class SecretAppsettingReader
    {
        public string ReadValue(string keyName)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            var configurationRoot = builder.Build();
            return configurationRoot.GetValue<string>(keyName);
        }
        public T ReadSection<T>(string sectionName)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            var configurationRoot = builder.Build();

            return configurationRoot.GetSection(sectionName).Get<T>();
        }
    }
}