using Microsoft.AspNetCore.Mvc;

namespace Ensek.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadsController : ControllerBase
    {

        [HttpPost, Route("meter-readings")]
        public async Task<IActionResult> UploadMeterReadingCsv([FromForm] IFormFile csvFile)
        {
            //todo
            return Ok();
        }

        [HttpPost, Route("accounts")]
        public async Task<IActionResult> UploadAccountSeedData([FromForm] IFormFile csvFile)
        {
            //todo
            return Ok();
        }
    }
}