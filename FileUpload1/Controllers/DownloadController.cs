using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FileUpload1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly string filePath;

        public DownloadController(string filePath)
        {
            this.filePath = filePath;
        }
        [HttpGet]
        public FileContentResult Get()
        {
            return File(System.IO.File.ReadAllBytes(filePath),"application/octet-stream","File.csv");
            // var result = new FileContentResult(data, "application/octet-stream")
            // {
            //     FileDownloadName = "File.csv"
            // };
            // return result;
        }
    }
}