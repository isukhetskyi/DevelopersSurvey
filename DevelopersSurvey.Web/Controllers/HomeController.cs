using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevelopersSurvey.Contracts.DataContracts;
using DevelopersSurvey.Contracts.Services;

namespace DevelopersSurvey.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRespondentsService respondentService;

        public HomeController(IRespondentsService respondentsService)
        {
            this.respondentService = respondentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSurvey(RespondentDto respondent)
        {
            this.respondentService.Add(respondent);
            return View();
        }
    }
}
