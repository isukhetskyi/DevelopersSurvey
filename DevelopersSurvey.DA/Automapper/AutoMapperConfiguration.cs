// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperConfiguration.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 
// </copyright>
// <summary>
//   Defines the AutoMapperConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Automapper
{
    using AutoMapper;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.DA.Models;

    /// <summary>
    /// The auto mapper configuration.
    /// </summary>
    public class AutoMapperConfiguration
    {
        /// <summary>
        /// The global mapper.
        /// </summary>
        public static IMapper GlobalMapper;

        /// <summary>
        /// The global mapper configuration.
        /// </summary>
        public static MapperConfiguration GlobalMapperConfiguration;

        public static void Configure()
        {
            GlobalMapperConfiguration = new MapperConfiguration(
                cfg =>
                    {
                        cfg.CreateMap<RespondentDto, Respondent>();
                        cfg.CreateMap<Respondent, RespondentDto>();
                    });
        }
    }


}
