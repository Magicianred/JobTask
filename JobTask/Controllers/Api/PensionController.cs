using JobTask.ServiceLayer;
using JobTask.ServiceLayer.Pension;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensionController : ControllerBase
    {
        private readonly IPensionService pensionService;

        public PensionController(IPensionService _pensionService)
        {
            pensionService = _pensionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pensionResult = await pensionService.GetPensionDataAsync();

            return Ok(pensionResult == null ? new PensionModel() : pensionResult);
        }

        [HttpGet("get-tin")]
        public async Task<IActionResult> GetTin(string pinfl)
        {
            var tinResult = await pensionService.GetPensionTinAsync(pinfl);

            return Ok(tinResult == null ? new PensionModel() : tinResult);
        }
    }
}
