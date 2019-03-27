using AutoMapper;
using DataFeed.HotelImport.Entities;
using DataFeed.Importer;
using DataFeed.Processor.Api;
using DataFeed.ReaderFactory.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            return base.CreateReaderFactory(services);
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
