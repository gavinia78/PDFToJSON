using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDFToJSON.Models;

namespace PDFToJSON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvertPDFToJSONController : ControllerBase
    {

        private readonly ILogger<ConvertPDFToJSONController> _logger;

        public ConvertPDFToJSONController(ILogger<ConvertPDFToJSONController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] FileUploadModel fileDetails)
        {
            if (fileDetails == null)
            {
                return BadRequest();
            }
            try
            {
                //var content = new System.IO.MemoryStream(fileDetails.FileDetails.Result.FileData);
                //var path = Path.Combine(
                //   Directory.GetCurrentDirectory(), "FileDownloaded",
                //   fileDetails.FileDetails.Result.Result.FileName);

                //using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                //{
                //    await content.CopyToAsync(fileStream);
                //}

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
