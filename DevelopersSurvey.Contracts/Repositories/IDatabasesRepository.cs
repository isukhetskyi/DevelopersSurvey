// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabasesRepository.cs" company="Peaceful Dev">
// Copyrights by Peaceful Dev 2017  
// </copyright>
// <summary>
//   Defines the IDatabasesRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Repositories
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The DatabasesRepository interface.
    /// </summary>
    public interface IDatabasesRepository
    {
        /// <summary>
        /// Gets all respondents' databases
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<DatabasesDto> GetAll();
    }
}
