﻿using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels;
using WeLearn.Web.ViewModels.Home;

namespace WeLearn.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInformationService informationService;

        public HomeController(IInformationService informationService)
            => this.informationService = informationService;

        public IActionResult Index()
        {
            IndexViewModel model = this.informationService.GenerateIndexViewModel();
            return this.View(model);
        }

        public IActionResult Faq()
        {
            FrequentQuestionsViewModel model = this.informationService.GenerateFrequentQuestionsViewModel();
            return this.View(model);
        }

        public IActionResult Privacy() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
    }
}
