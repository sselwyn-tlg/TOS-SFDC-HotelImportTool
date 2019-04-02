using AutoMapper;
using DataFeed.HotelImport.Entities;
using DataFeed.HotelImport.WriterService.Aerospike;
using DataFeed.Importer;
using DataFeed.Processor.Api;
using DataFeed.ReaderFactory.Core;
using DataFeed.WriterService.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DataFeed.HotelImport.Console
{
    public class ProcessorServices : WebApiProcessorServices
    {
        #region Member Variables

        /// <summary>
        /// The <see cref="IConfiguration"/> instance that contains the settings.
        /// </summary>
        private readonly IConfiguration _configuration = null;

        #endregion

        public ProcessorServices(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        protected override Func<IServiceProvider, Func<ImportSettings, IReaderFactory>> CreateReaderFactory(IServiceCollection services)
        {
            // Add factory
            services.AddTransient<ReaderFactory>();

            return new Func<IServiceProvider, Func<ImportSettings, IReaderFactory>>(serviceProvider => key =>
            {
                return serviceProvider.GetService<ReaderFactory>();
            });
        }

        protected override void AddLoggingServices(IServiceCollection services)
        {
            services.AddLogging(c => c.AddConsole());
            base.AddLoggingServices(services);
        }

        /// <summary>
        /// Represents the method that is responsible for initializing all writer instances
        /// and to provide a function delegate which can be used to pick a factory based on the settings.
        /// </summary>
        /// <param name="services">
        /// The <see cref="IServiceCollection"/> instance being built.
        /// </param>
        /// <returns>
        /// a <see cref="Func{T, TResult}"/> delegate 
        /// where T is the <see cref="IServiceProvider"/> passed by the dependency injection;
        /// where TResult is the underlying function delegate that shall return 
        /// an <see cref="IWriterService"/> instance based on the key that is being passed.
        /// </returns>
        protected override Func<IServiceProvider, Func<ImportSettings, IWriterService>> CreateWriterFactory(IServiceCollection services)
        {
            services.AddTransient<AeroSpikeWriterService>();

            return new Func<IServiceProvider, Func<ImportSettings, IWriterService>>(serviceProvider => settings =>
            {
                var dataWriter = serviceProvider.GetRequiredService<AeroSpikeWriterService>();
                dataWriter.Settings = new AeroSpikeWriterSettings()
                {
                    
                };
                return dataWriter;

                //SWITCH IF YOU WANT TO WRITE TO DATABASE.
                ////Passing NULL for repositiory as we want to make sure it is scoped before calling SaveEntities
                //var dataWriter = serviceProvider.GetRequiredService<DatabaseWriterService<GenericContext, DatabaseWriterSettings>>();
                //dataWriter.Settings = new DatabaseWriterSettings()
                //{
                //    DatabaseWriterOption = settings.TargetDatabaseWriterOption,
                //    CommandDetails = $"JobID: {settings.Job?.JobID}, DataSource: {settings.DataSource}, SourceDataType: {settings.SourceDataType}, TargetDataType: {settings.TargetDataType}",
                //};
                //return dataWriter;
            });
        }

        protected override void AddSettings(IServiceCollection services)
        {
            services.Configure<SalesForceSettings>(_configuration.GetSection("SalesForceSettings"));

            base.AddSettings(services);
        }

        /// <summary>
        /// Represents the method that configures the data mappers for the injection.
        /// </summary>
        /// <param name="services">
        /// The <see cref="IMapperConfigurationExpression"/> instance being configured.
        /// </param>
        protected override void ConfigureDataMappers(IMapperConfigurationExpression mapperConfiguration)
        {
            base.ConfigureDataMappers(mapperConfiguration);

            mapperConfiguration.AddProfiles(typeof(HotelMapperProfile));            
        }
    }
}
