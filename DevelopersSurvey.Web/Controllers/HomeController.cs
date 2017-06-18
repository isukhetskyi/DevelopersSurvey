using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevelopersSurvey.Contracts.DataContracts;
using DevelopersSurvey.Contracts.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevelopersSurvey.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRespondentsService _respondentsService;

        public HomeController(IRespondentsService respondentsService)
        {
            this._respondentsService = respondentsService;
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
        public IActionResult SubmitSurvey(string respondent)
        {
            var newRespondent = JsonConvert.DeserializeObject<RespondentDto>(respondent);
            this._respondentsService.Add(newRespondent);
            return View();
        }
    }
}
