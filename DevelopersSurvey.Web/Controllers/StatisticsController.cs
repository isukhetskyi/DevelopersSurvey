// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatisticsController.cs" company="Peaceful Dev">
//   Copyright by Peaceful Dev
// </copyright>
// <summary>
//   Defines the StatisticsController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Controllers
{
    using System.Linq;

    using DevelopersSurvey.Contracts.Services;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The statistics controller.
    /// </summary>
    public class StatisticsController : BaseController
    {
        /// <summary>
        /// The respondents service.
        /// </summary>
        private readonly IRespondentsService respondentsService;

        /// <summary>
        /// The frameworks service.
        /// </summary>
        private readonly IFrameworksService frameworksService;

        /// <summary>
        /// The databases service.
        /// </summary>
        private readonly IDatabasesService databasesService;

        /// <summary>
        /// The programming languages service.
        /// </summary>
        private readonly IProgrammingLanguagesService programmingLanguagesService;

        /// <summary>
        /// The experiance service.
        /// </summary>
        private readonly IExperianceService experianceService;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsController"/> class.
        /// </summary>
        /// <param name="respondentsService">
        /// The respondents service.
        /// </param>
        /// <param name="frameworksService">
        /// The frameworks Service.
        /// </param>
        /// <param name="databasesService">
        /// The databases Service.
        /// </param>
        /// <param name="programmingLanguagesService">
        /// The programming Languages Service.
        /// </param>
        /// <param name="experianceService">
        /// The experiance service
        /// </param>
        public StatisticsController(
            IRespondentsService respondentsService,
            IFrameworksService frameworksService,
            IDatabasesService databasesService,
            IProgrammingLanguagesService programmingLanguagesService,
            IExperianceService experianceService)
        {
            this.respondentsService = respondentsService;
            this.frameworksService = frameworksService;
            this.databasesService = databasesService;
            this.programmingLanguagesService = programmingLanguagesService;
            this.experianceService = experianceService;
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The get statistics data.
        /// </summary>
        /// <returns>
        /// The <see cref="JsonResult"/>.
        /// </returns>
        public JsonResult GetStatisticsData()
        {
            var respondents = this.respondentsService.GetAll();
            var frameworks = this.frameworksService.GetAll().ToList();
            var databases = this.databasesService.GetAll();
            var expericances = this.experianceService.GetAll();
            var programmingLanguages = this.programmingLanguagesService.GetAll();

            var frameworkStatistics = frameworks
                .Join(
                    expericances,
                    f => f.ExperianceId,
                    e => e.Id,
                    (f, e) => new { Id = e.Id, Framework = e.Name, RespondentId = f.RespondentId }).GroupBy(
                    f => f.Framework,
                    f => f.RespondentId,
                    (key, values) => new { Framework = key, Number = values.Count() });

            var databasesStatistics = databases
                .Join(
                    expericances,
                    d => d.ExperianceId,
                    e => e.Id,
                    (d, e) => new { Id = e.Id, Database = e.Name, RespondentId = d.RespondentId }).GroupBy(
                    f => f.Database,
                    f => f.RespondentId,
                    (key, values) => new { Database = key, Number = values.Count() });

            var programmingLanguagesStatistics = programmingLanguages
                .Join(
                    expericances,
                    pl => pl.ExperianceId,
                    e => e.Id,
                    (pl, e) => new { Id = e.Id, ProgrammingLanguage = e.Name, RespondentId = pl.RespondentId }).GroupBy(
                    f => f.ProgrammingLanguage,
                    f => f.RespondentId,
                    (key, values) => new { ProgrammingLanguage = key, Number = values.Count() });

            var ageStatistics = respondents.GroupBy(
                r => r.Id,
                r => r.Age,
                (key, values) => new { Age = key, Count = values.Count() });

            return Json(
                new
                    {
                        FrameworkStatistics = frameworkStatistics,
                        DatabasesStatistics = databasesStatistics,
                        ProgrammingLanguagesStatistics = programmingLanguagesStatistics,
                        AgeStatistics = ageStatistics
                    });
        }
    }
}