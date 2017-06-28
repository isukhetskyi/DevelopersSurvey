// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SurveyController.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the SurveyController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Controllers
{
    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Services;

    using Microsoft.AspNetCore.Mvc;

    using Newtonsoft.Json;

    /// <summary>
    /// The survey controller.
    /// </summary>
    public class SurveyController : Controller
    {
        /// <summary>
        /// The respondents service.
        /// </summary>
        private IRespondentsService respondentsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyController"/> class.
        /// </summary>
        /// <param name="respondentsService">
        /// The respondents service.
        /// </param>
        public SurveyController(IRespondentsService respondentsService)
        {
            this.respondentsService = respondentsService;
        }

        /// <summary>
        /// Returns survey index view
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Saves new respondent into database
        /// </summary>
        /// <param name="respondent">
        /// The respondent.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        [HttpPost]
        public IActionResult SubmitSurvey(string respondent)
        {
            var newRespondent = JsonConvert.DeserializeObject<RespondentDto>(respondent);
            this.respondentsService.Add(newRespondent);
            return View("Success");
        }
    }
}