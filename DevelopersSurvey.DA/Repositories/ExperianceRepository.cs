// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExperianceRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the ExperianceRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    
    /// <summary>
    /// The experiance repository.
    /// </summary>
    public class ExperianceRepository : IExperianceRepository
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
        /// Initializes a new instance of the <see cref="ExperianceRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="mapper">
        /// The mapper
        /// </param>
        public ExperianceRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets all experiance records from database
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<ExperianceDto> GetAll()
        {
            return this.mapper.Map<List<ExperianceDto>>(this.context.Experiances.ToList());
        }
    }
}
