// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabasesService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IDatabasesService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The DatabasesService interface.
    /// </summary>
    public interface IDatabasesService
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
