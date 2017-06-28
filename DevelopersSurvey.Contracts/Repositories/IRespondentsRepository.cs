// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRespondentsRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   The ResopondentsRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Repositories
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The ResopondentsRepository interface.
    /// </summary>
    public interface IRespondentsRepository
    {
        /// <summary>
        /// Add new respondent entry to the database
        /// </summary>
        /// <param name="newEntry">
        /// The new entry object
        /// </param>
        /// <returns>
        /// Added respondent<see cref="RespondentDto"/>.
        /// </returns>
        RespondentDto Add(RespondentDto newEntry);

        /// <summary>
        /// Gets respondent by their id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The found respondent <see cref="RespondentDto"/>.
        /// </returns>
        RespondentDto GetById(int id);

        /// <summary>
        /// Get all respondents
        /// </summary>
        /// <returns>
        /// The collection with all respondents <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<RespondentDto> GetAll();
    }
}
