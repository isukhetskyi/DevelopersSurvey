// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProgrammingLanguagesRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IProgrammingLanguagesRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Repositories
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The ProgrammingLanguagesRepository interface.
    /// </summary>
    public interface IProgrammingLanguagesRepository
    {
        /// <summary>
        /// Gets all respondents' programming languages
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<ProgrammingLanguagesDto> GetAll();
    }
}
