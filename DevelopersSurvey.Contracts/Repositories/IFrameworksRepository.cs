// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFrameworksRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev
// </copyright>
// <summary>
//   Defines the IFrameworksRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Repositories
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The FrameworksRepository interface.
    /// </summary>
    public interface IFrameworksRepository
    {
        /// <summary>
        /// Gets all respondents' frameworks
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<FrameworksDto> GetAll();
    }
}
