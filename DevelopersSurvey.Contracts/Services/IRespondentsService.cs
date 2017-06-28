// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRespondentsService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the IRespondentsService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.Common;
    using DevelopersSurvey.Contracts.DataContracts;

    /// <summary>
    /// The RespondentsService interface.
    /// </summary>
    public interface IRespondentsService
    {
        /// <summary>
        /// Adds new entry of Respondent
        /// </summary>
        /// <param name="newEntry">
        /// The new entry.
        /// </param>
        /// <returns>
        /// The added object <see cref="RespondentDto"/>.
        /// </returns>
        CommonResultGeneric<RespondentDto> Add(RespondentDto newEntry);

        /// <summary>
        /// Gets respondent by their id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="RespondentDto"/>.
        /// </returns>
        CommonResultGeneric<RespondentDto> GetById(int id);

        /// <summary>
        /// Gets all respondents
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<RespondentDto> GetAll();
    }
}
