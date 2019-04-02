using IdentityModel.Client;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using System;

namespace DataFeed.HotelImport.Console
{
    public static class ConfigHelper
    {

        /// <summary>
        /// A flag to indicate if initialization of the DocumentClient has completed.
        /// </summary>
        private static bool _initializationComplete = false;

        /// <summary>
        /// A lock object over the initialization process.
        /// </summary>
        private static object _initializationLockObject = new object();

        /// <summary>
        /// Global configuration object.
        /// </summary>
        private static IConfiguration configuration;

        /// <summary>
        /// Initialize the CosmosDB clients.
        /// </summary>
        public static IConfiguration LoadConfiguration(string currentDirectory)
        {
            if (!_initializationComplete)
            {
                lock (_initializationLockObject)
                {
                    if (!_initializationComplete)
                    {

                        var builder = new ConfigurationBuilder();

                        // Add the JSON configuration values as the initial set
                        var config = builder.SetBasePath(currentDirectory)
                            .AddJsonFile("appSettings.json", false, true)
                            .AddEnvironmentVariables()
                            .Build();

                        // Add Azure Key Vault to pull configuration values from the vault (overriding any JSON values already set)
                        var azureServiceTokenProvider = new AzureServiceTokenProvider();
                        var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
                        builder.AddAzureKeyVault(config["AppSettings:KeyVaultUri"], keyVaultClient, new DefaultKeyVaultSecretManager());

                        // Add the JSON configuration values again (overriding any values from the vault for local development)
                        builder.AddJsonFile("appSettings.json", false, true);

                        configuration = builder.Build();

                        // Initialization is complete.
                        _initializationComplete = true;
                    }
                }
            }
            return configuration;
        }

        /// <summary>
        /// Get the connection string with the given name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static string GetConnectionString(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            try
            {
                string connectionString = configuration.GetConnectionString(name);
                return connectionString;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to find a connection string with name: {name}. Error: {e.Message}");
            }
        }
    }
}
