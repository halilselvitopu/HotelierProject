using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;

namespace HotelierProject.WebApi.Controllers
{
    public class FileProcessController : Controller
    {
        [HttpPost]

        public async Task<IActionResult> UploadFile([FromForm] IFormFile formFile)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "files/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await formFile.CopyToAsync(stream);
            return Created("", formFile);
        }
    }
}
