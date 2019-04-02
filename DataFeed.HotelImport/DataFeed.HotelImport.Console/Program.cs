using DataFeed.MetaData.Core;
using DataFeed.Processor.Api;
using DataFeed.Processor.Core;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DataFeed.HotelImport.Console
{
    class Program
    {
        private static IServiceProvider _serviceProvider = null;

        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        private static async Task<IServiceProvider> CreateServiceProvider(string currentDirectory)
        {
            try
            {
                await _semaphore.WaitAsync();

                if (_serviceProvider == null)
                {
                    // Load the configuration settings
                    var configuration = ConfigHelper.LoadConfiguration(currentDirectory);

                    

                    // Add services
                    var services = new ProcessorServices(configuration);

                    _serviceProvider = await services.BuildServiceProvider();
                }

                return _serviceProvider;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        static async Task Main(string[] args)
        {
            try
            {
                var app = new CommandLineApplication(throwOnUnexpectedArg: true)
                {
                    FullName = "Data Feed Hotel Import",
                    Name = "dotnet DataFeed.HotelImport.Console.dll"
                };

                app.HelpOption(template: "-h | -? | --help ");

                var serviceProvider = await CreateServiceProvider(Directory.GetCurrentDirectory());

                app.OnExecute(async () =>
                {
                    var processor = serviceProvider.GetService<IDataProcessor>();

                    var job = CreateJob("");

                    if (job == null)
                    {
                        throw new ArgumentException("The queue item is not a valid job instance.", "myQueueItem");
                    }

                    await processor.ProcessAsync(job);

                    return 0;
                });

                app.Execute(args);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.GetBaseException().Message);
                System.Console.WriteLine(e);
            }
            finally
            {
                System.Console.WriteLine("Done!");
            }
        }

        private static Job CreateJob(string args)
        {
            return new Job()
            {
                JobID = DateTime.UtcNow.Ticks,
                BatchCount = 1000,
                WorkflowItemType = WorkflowItemType.Import,
                SourceType = SourceType.WebApi,
                Detail = "",
                DataSourceWebApiDetail = new DataSourceWebApi()
                {
                    ApiFormat = args,
                    ApiBaseURL = "https://travelleaders.my.salesforce.com/",
                    ApiUrl = "services/data/v20.0/query",
                    ApiUrlParameters = new System.Collections.Generic.Dictionary<string, string>(),
                    SourceDatabaseOptions = new DatabaseCommandFormat()
                    {
                        DatabaseConnectionName = "StagingContext",
                        DatabaseName = "MarketoAnalytics",
                        SqlCommand = "",
                        SqlConnectionTestCommand = "SELECT GETUTCDATE()"
                    },
                    SourceDataType = typeof(Entities.Source.Hotel__c).AssemblyQualifiedName,
                    TargetDataType = typeof(Entities.Target.Hotel).AssemblyQualifiedName,
                    TargetDatabaseOptions = new DatabaseCommandFormat()
                    {
                        DatabaseConnectionName = "StagingContext",
                        DatabaseName = "MarketoAnalytics",
                        SqlConnectionTestCommand = "SELECT GETUTCDATE()"
                    }
                }
            };
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }        
    }
}
