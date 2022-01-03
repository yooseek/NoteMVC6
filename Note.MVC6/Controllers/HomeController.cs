﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.BLL;
using Note.MVC6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Note.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoticeBll _noticeBll;
        
        public HomeController(ILogger<HomeController> logger, NoticeBll noticeBll)
        {
            _logger = logger;
            _noticeBll = noticeBll;
        }

        public IActionResult Index()
        {
            var List = _noticeBll.GetNoticeList();
            _logger.LogTrace($"홈화면 : {MethodBase.GetCurrentMethod().Name}");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
