// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsController.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev
// </copyright>
// <summary>
//   Defines the RespondentsController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Controllers
{
    using DevelopersSurvey.Contracts.Services;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The respondents controller.
    /// </summary>
    public class RespondentsController : BaseController
    {
        /// <summary>
        /// The respondents service.
        /// </summary>
        private readonly IRespondentsService respondentsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RespondentsController"/> class.
        /// </summary>
        /// <param name="respondentsService">
        /// The respondents service.
        /// </param>
        public RespondentsController(IRespondentsService respondentsService)
        {
            this.respondentsService = respondentsService;
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
        /// Gets all respondents from the database.
        /// </summary>
        /// <returns>
        /// The <see cref="JsonResult"/>.
        /// </returns>
        public JsonResult GetRespondents()
        {
            return Json(new { respondents = this.respondentsService.GetAll() });
        }

        /// <summary>
        /// Returns specific respondent by it's id
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="JsonResult"/>.
        /// </returns>
        public JsonResult GetById(int id)
        {
            return Json(new { respondent = this.respondentsService.GetById(id) });
        }
    }
}
