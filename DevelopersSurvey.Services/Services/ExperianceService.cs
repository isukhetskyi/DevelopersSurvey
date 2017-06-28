// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExperianceService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the ExperianceService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Services.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;

    /// <summary>
    /// The experiance service.
    /// </summary>
    public class ExperianceService : IExperianceService
    {
        /// <summary>
        /// The experiance repository.
        /// </summary>
        private readonly IExperianceRepository experianceRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperianceService"/> class.
        /// </summary>
        /// <param name="experianceRepository">
        /// The experiance repository.
        /// </param>
        public ExperianceService(IExperianceRepository experianceRepository)
        {
            this.experianceRepository = experianceRepository;
        }

        /// <summary>
        /// Returns all epxeriance records from databasse.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<ExperianceDto> GetAll()
        {
            return this.experianceRepository.GetAll();
        }
    }
}
