using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Daily_Cash_Trading_Limits.Models;
using Daily_Cash_Trading_Limits.Services;

namespace Daily_Cash_Trading_Limits.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBankService _bankService;

        public HomeController(ILogger<HomeController> logger, IBankService bankService)
        {
            _logger = logger;
            _bankService = bankService;
        }

        public IActionResult Index()
        {
            // call service and store results
            IEnumerable<BankTradingInfoModel> viewModel = _bankService.GetAllBanksInfo();
                //  change back to List<BankTradingInfoModel> if IEnumerable becomes a problem
            // return results with view >>> return View(results);
            return View(viewModel);
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
