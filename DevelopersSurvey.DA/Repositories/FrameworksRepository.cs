// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrameworksRepository.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the FrameworksRepository type.
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
    /// The frameworks repository.
    /// </summary>
    public class FrameworksRepository : IFrameworksRepository
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
        /// Initializes a new instance of the <see cref="FrameworksRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="mapper">
        /// The mapper.
        /// </param>
        public FrameworksRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<FrameworksDto> GetAll()
        {
            return this.mapper.Map<List<FrameworksDto>>(this.context.Frameworks.ToList());
        }
    }
}
