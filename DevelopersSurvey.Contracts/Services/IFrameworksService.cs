// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFrameworksService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IFrameworksRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The FrameworksRepository interface.
    /// </summary>
    public interface IFrameworksService
    {
        /// <summary>
        /// Returns all respondents' framework records
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<FrameworksDto> GetAll();
    }
}
