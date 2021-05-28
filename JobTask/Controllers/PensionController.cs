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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PensionModel model)
        {
            //todo something
            var result = await pensionService.PostDataAsync(model);
            return Ok(result);
        }
    }
}
