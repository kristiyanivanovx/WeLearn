﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WeLearn.Common.Constants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class ManageController : AdministrationController
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
