// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProgrammingLanguagesService.cs" company="Peaceful Dev">
//   Copyrigths by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IProgrammingLanguagesService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The ProgrammingLanguagesService interface.
    /// </summary>
    public interface IProgrammingLanguagesService
    {
        /// <summary>
        /// Returns all respondents' programming languages list
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<ProgrammingLanguagesDto> GetAll();
    }
}
