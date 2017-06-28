// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrameworksService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev
// </copyright>
// <summary>
//   Defines the FrameworksService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Services.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;

    /// <summary>
    /// The frameworks service.
    /// </summary>
    public class FrameworksService : IFrameworksService
    {
        /// <summary>
        /// The frameworks repository.
        /// </summary>
        private IFrameworksRepository frameworksRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameworksService"/> class.
        /// </summary>
        /// <param name="frameworksRepository">
        /// The frameworks repository.
        /// </param>
        public FrameworksService(IFrameworksRepository frameworksRepository)
        {
            this.frameworksRepository = frameworksRepository;
        }

        /// <summary>
        /// Gets all respondents' frameworks
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<FrameworksDto> GetAll()
        {
            return this.frameworksRepository.GetAll();
        }
    }
}
