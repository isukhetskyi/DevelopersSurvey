// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExperianceService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IExperianceService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The ExperianceService interface.
    /// </summary>
    public interface IExperianceService
    {
        /// <summary>
        /// Gets all experiance records from database
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<ExperianceDto> GetAll();
    }
}
