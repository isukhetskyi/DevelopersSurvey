// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
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

    using AutoMapper;

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
        private readonly ApplicationDbContext context;

        /// <summary>
        /// The mapper.
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="RespondentsRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The application db context injection
        /// </param>
        /// <param name="mapper">
        /// Automapper injection
        /// </param>
        public RespondentsRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
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
            var newRepondent = this.mapper.Map<Respondent>(newEntry);
            this.context.Respondents.Add(newRepondent);
            this.context.SaveChanges();
            newEntry.Id = newRepondent.Id;

            var programmingLanguages = this.context.Experiances.Join(
                newEntry.ProgrammingLanguagesString.Split(','),
                pl => pl.Name,
                pls => pls,
                (pl, pls) => new ProgrammingLanguagesDto { ExperianceId = pl.Id, RespondentId = newRepondent.Id })
                .ToList();

            var framewors = this.context.Experiances.Join(
                    newEntry.FrameworksString.Split(','),
                    pl => pl.Name,
                    pls => pls,
                    (pl, pls) => new FrameworksDto { ExperianceId = pl.Id, RespondentId = newRepondent.Id })
                .ToList();


            var databases = this.context.Experiances.Join(
                    newEntry.DatabasesString.Split(','),
                    pl => pl.Name,
                    pls => pls,
                    (pl, pls) => new DatabasesDto { ExperianceId = pl.Id, RespondentId = newRepondent.Id })
                .ToList();
            this.context.ProgrammingLanguages.AddRange(
                this.mapper.Map<List<ProgrammingLanguages>>(programmingLanguages));
            this.context.Frameworks.AddRange(
                this.mapper.Map<List<Frameworks>>(framewors));
            this.context.Databases.AddRange(
                this.mapper.Map<List<Databases>>(databases));

            this.context.SaveChanges();
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
            return this.mapper.Map<RespondentDto>(
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
            return this.mapper.Map<List<RespondentDto>>(
                this.context.Respondents.ToList());
        }
    }
}
