using JobTask.ServiceLayer.Pension;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IPensionService pensionService;

        public HomeController(IPensionService _pensionService)
        {
            pensionService = _pensionService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("GetTin");
        }

        [HttpGet]
        public IActionResult GetTin()
        {
            return View();
        }

        [HttpGet("get-tin")]
        public async Task<IActionResult> Index(string pinfl)
        {
            PensionTinModel tempModel = null;
            
            if(pinfl != null)
                tempModel = await pensionService.GetPensionTinAsync(pinfl);
            
            return View("GetTin", tempModel);
        }

    }
}
