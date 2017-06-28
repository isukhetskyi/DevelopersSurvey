// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsService.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the RespondentsService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Services.Services
{
    using System.Collections.Generic;

    using DevelopersSurvey.Contracts.Common;
    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;

    /// <summary>
    /// The respondents service.
    /// </summary>
    public class RespondentsService : IRespondentsService
    {
        /// <summary>
        /// The respondents repository.
        /// </summary>
        private readonly IRespondentsRepository respondentsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RespondentsService"/> class.
        /// </summary>
        /// <param name="respondentsRepository">
        /// The respondents repository.
        /// </param>
        public RespondentsService(IRespondentsRepository respondentsRepository)
        {
            this.respondentsRepository = respondentsRepository;
        }

        /// <summary>
        /// Adds new respondent to database
        /// </summary>
        /// <param name="newEntry">
        /// The new entry.
        /// </param>
        /// <returns>
        /// The <see cref="CommonResultGeneric{T}"/>.
        /// </returns>
        public CommonResultGeneric<RespondentDto> Add(RespondentDto newEntry)
        {
            var respondent = this.respondentsRepository.Add(newEntry);
            if (respondent.Id == 0)
            {
                return CommonResultGeneric<RespondentDto>.Failure<RespondentDto>(
                    "Some problems occured while adding new rewspondent");
            }

            return CommonResultGeneric<RespondentDto>.Success(respondent);
        }

        /// <summary>
        /// Gets respondent by their id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="CommonResultGeneric{T}"/>.
        /// </returns>
        public CommonResultGeneric<RespondentDto> GetById(int id)
        {
            var respondent = this.respondentsRepository.GetById(id);
            if (respondent == null)
            {
                return CommonResultGeneric<RespondentDto>.Failure<RespondentDto>(
                    "Problems occured while fetchin respondent by given id");
            }

            return CommonResultGeneric<RespondentDto>.Success(respondent);
        }

        /// <summary>
        /// Gets all respondents
        /// </summary>
        /// <returns>
        /// The collection of respondents <see cref="IEnumerable{T}"/>.
        /// </returns>
        public IEnumerable<RespondentDto> GetAll()
        {
            return this.respondentsRepository.GetAll();
        }
    }
}
