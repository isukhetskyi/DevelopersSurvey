// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExperianceRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IExperianceRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Repositories
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The ExperianceRepository interface.
    /// </summary>
    public interface IExperianceRepository
    {
        /// <summary>
        /// Get all experiance records from database
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<ExperianceDto> GetAll();
    }
}
