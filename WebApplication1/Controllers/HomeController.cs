using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IIngressoApiService _ingressoApiService;

        public HomeController(ILogger<HomeController> logger, IIngressoApiService ingressoApiService)
        {
            _logger = logger;
            _ingressoApiService = ingressoApiService;
        }

        public IActionResult Index()
        {
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

        [HttpGet]
        public async Task<IActionResult> GetMonth(string event_id)
        {
            List<MonthModel> monthModels = new List<MonthModel>();

            if (!string.IsNullOrEmpty(event_id))
            {
                monthModels = await _ingressoApiService.GetMonths(event_id);
            }

            return View(monthModels);
        }
    }
}

