// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabasesService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the DatabasesService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Services.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;

    /// <summary>
    /// The databases service.
    /// </summary>
    public class DatabasesService : IDatabasesService
    {
        /// <summary>
        /// The databases repository.
        /// </summary>
        private readonly IDatabasesRepository databasesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabasesService"/> class.
        /// </summary>
        /// <param name="databasesRepository">
        /// The databases repository.
        /// </param>
        public DatabasesService(IDatabasesRepository databasesRepository)
        {
            this.databasesRepository = databasesRepository;
        }

        /// <summary>
        /// Gets all respondents' databases
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<DatabasesDto> GetAll()
        {
            return this.databasesRepository.GetAll();
        }
    }
}
