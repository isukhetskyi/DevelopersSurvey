// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProgrammingLanguagesService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the ProgrammingLanguagesService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Services.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;

    /// <summary>
    /// The programming languages service.
    /// </summary>
    public class ProgrammingLanguagesService : IProgrammingLanguagesService
    {
        /// <summary>
        /// The programming languages repository.
        /// </summary>
        private readonly IProgrammingLanguagesRepository programmingLanguagesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammingLanguagesService"/> class.
        /// </summary>
        /// <param name="programmingLanguagesRepository">
        /// The programming languages repository.
        /// </param>
        public ProgrammingLanguagesService(IProgrammingLanguagesRepository programmingLanguagesRepository)
        {
            this.programmingLanguagesRepository = programmingLanguagesRepository;
        }

        /// <summary>
        /// Gets all respondents' programming languages
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<ProgrammingLanguagesDto> GetAll()
        {
            return this.programmingLanguagesRepository.GetAll();
        }
    }
}
