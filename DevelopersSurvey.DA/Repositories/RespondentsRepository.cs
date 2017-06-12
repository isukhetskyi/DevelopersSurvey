// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsRepository.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the RespondentsRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.DA.Automapper;
    using DevelopersSurvey.DA.Models;

    /// <summary>
    /// The respondents repository.
    /// </summary>
    public class RespondentsRepository : IRespondentsRepository
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="RespondentsRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The application db context.
        /// </param>
        public RespondentsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="newEntry">
        /// The new entry.
        /// </param>
        /// <returns>
        /// The <see cref="RespondentDto"/>.
        /// </returns>
        public RespondentDto Add(RespondentDto newEntry)
        {
            var newRepondent = AutoMapperConfiguration.GlobalMapper.Map<RespondentDto, Respondent>(newEntry);
            this.context.Respondents.Add(newRepondent);
            newEntry.Id = newRepondent.Id;
            return newEntry;
        }

        /// <summary>
        /// Gets respondent by their id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The found respondent <see cref="RespondentDto"/>.
        /// </returns>
        public RespondentDto GetById(int id)
        {
            return AutoMapperConfiguration.GlobalMapper.Map<Respondent, RespondentDto>(
                this.context.Respondents.FirstOrDefault(r => r.Id == id));
        }

        /// <summary>
        /// Gets all respondents from database.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<RespondentDto> GetAll()
        {
            return AutoMapperConfiguration.GlobalMapper.Map<List<Respondent>, List<RespondentDto>>(
                this.context.Respondents.ToList());
        }
    }
}
