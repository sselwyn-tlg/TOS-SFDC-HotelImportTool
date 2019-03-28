using DataFeed.Entities.Core;
using DataFeed.WriterService.Core;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataFeed.HotelImport.WriterService.Aerospike
{
    /// <summary>
    /// Represents the class that writes records to AeroSpike.
    /// </summary>
    public class AeroSpikeWriterService : BaseWriterService<AeroSpikeWriterSettings>
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of AeroSpikeWriterService
        /// </summary>
        /// <param name="logger">
        /// The <see cref="ILogger"/> instance for logging messages.
        /// </param>
        public AeroSpikeWriterService(ILogger<AeroSpikeWriterService> logger) : base(logger)
        {

        }

        #endregion


        #region Base Methods Overridden

        /// <summary>
        /// Represents the method that writes the entities to the target system.
        /// </summary>
        /// <param name="entities">
        /// The <see cref="IEnumerable{T}"/> instance that contains the entities to write.
        /// T is a <see cref="BaseTargetEntity"/>.
        /// </param>
        /// <returns>
        /// The <see cref="System.Int32"/> that contains the total no of records written.
        /// Count of records written
        /// </returns>
        protected override Task<int> WriteAsync(IEnumerable<BaseTargetEntity> entities)
        {
            int count = 0;

            foreach (var entity in entities)
            {
                _logger.LogDebug($"AeroSpike: Saving Entity {++count}.....");

                Task.Delay(250);
            }

            return Task.FromResult(count);
        }

        #endregion
    }
}
