using Microsoft.AspNetCore.Mvc;
using RentACar.Models;
using System.Diagnostics;

namespace RentACar.Controllers
{
    public class CarController
    {
        private readonly ILogger<HomeController> _logger;

        public CarController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
