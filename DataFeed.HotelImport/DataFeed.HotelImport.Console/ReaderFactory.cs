using AutoMapper;
using DataFeed.DataRepository;
using DataFeed.Entities.Core;
using DataFeed.Importer;
using DataFeed.Options.Processor;
using DataFeed.PollyDefinitions;
using DataFeed.ReaderFactory.Core;
using DataFeed.ReaderFactory.WebApi;
using DataFeed.ReaderService.Api.SalesForce;
using DataFeed.ReaderService.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DataFeed.HotelImport.Console
{
    class ReaderFactory : WebApiReaderFactory
    {
        #region Member Variables

        private readonly IMapper _mapper = null;
        private readonly ILogger _logger = null;
        private readonly SemaphoreSlim _throttle = null;
        private readonly IDapperRepository _dapperRepository = null;
        private readonly IAsyncRetryPolicy<HttpRequestException> _httpRequestRetryPolicy = null;
        private readonly SalesForceSettings _salesForceSettings = null;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ProcessorFactory"/>
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="mapper">Mapper</param>
        /// <param name="genericImporter">Generic importer</param>
        /// <param name="repository">Dapper repository</param>
        public ReaderFactory(ILogger<ReaderFactory> logger, IMapper mapper,
            IOptions<AppSettings> appSettings, IDapperRepository repository,
                IAsyncRetryPolicy<HttpRequestException> httpRequestRetryPolicy, IOptions<SalesForceSettings> salesForceSettings)
            : base(logger, mapper, appSettings, repository, httpRequestRetryPolicy)
        {
            _mapper = mapper;
            _logger = logger;
            _dapperRepository = repository;
            _httpRequestRetryPolicy = httpRequestRetryPolicy;

            _throttle = new SemaphoreSlim(appSettings.Value.ConcurApiThrottleCount);

            _salesForceSettings = salesForceSettings.Value;
        }

        #endregion


        public override IReaderService GetReaderService(ImportParameters parameters, ImportSettings importSettings)
        {
            return CreateSalesForceReader<Entities.Source.Hotel__c>(parameters, importSettings);
        }

        protected override Task<ApiSecretKey> GetApiSecretKeyAsync(int consumerID)
        {
            return Task.FromResult<ApiSecretKey>(null);
        }

        private IReaderService CreateSalesForceReader<T>
            (ImportParameters inputParameters, ImportSettings importSettings)
            where T : BaseEntity, new()
        {
            var settings = CreateOAuthWebApiReaderSettings<SalesForceReaderSettings<T>>(inputParameters, importSettings, null);
            settings.ApiBaseUrl = _salesForceSettings.SalesForceApiBaseUrl;
            settings.ApiUrl = importSettings.ApiUrl;
            settings.AuthorizationURL = _salesForceSettings.SalesForceAuthorizationURL;
            settings.ClientID = _salesForceSettings.SalesForceClientID;
            settings.ClientSecret = _salesForceSettings.SalesForceClientSecret;
            settings.UserName = _salesForceSettings.SalesForceUserName;
            settings.Password = _salesForceSettings.SalesForcePassword;

            var queryBuilder = new SalesForceQueryBuilder<SalesForceReaderSettings<T>>(_logger);

            return new SalesForceReaderService<SalesForceReaderSettings<T>>(_logger, _mapper, _dapperRepository, _httpRequestRetryPolicy, _throttle, queryBuilder)
            {
                Settings = settings
            };
        }
    }
}
