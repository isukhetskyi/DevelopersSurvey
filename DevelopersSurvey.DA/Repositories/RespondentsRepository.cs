// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsRepository.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the RespondentsRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AutoMapper;

namespace DevelopersSurvey.DA.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.DA.Models;

    /// <summary>
    /// The respondents repository.
    /// </summary>
    public class RespondentsRepository : IRespondentsRepository
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="RespondentsRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The application db context.
        /// </param>
        /// <param name="mapper">
        /// Automapper
        /// </param>
        public RespondentsRepository(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
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
            var newRepondent = _mapper.Map<Respondent>(newEntry);
            this._context.Respondents.Add(newRepondent);
            this._context.SaveChanges();
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
            return _mapper.Map<RespondentDto>(
                this._context.Respondents.FirstOrDefault(r => r.Id == id));
        }

        /// <summary>
        /// Gets all respondents from database.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<RespondentDto> GetAll()
        {
            return this._mapper.Map<List<RespondentDto>>(
                this._context.Respondents.ToList());
        }
    }
}
