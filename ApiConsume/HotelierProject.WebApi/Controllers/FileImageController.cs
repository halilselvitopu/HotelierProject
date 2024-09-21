using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]

        public async Task<IActionResult> UploadImage([FromForm]IFormFile formFile)
        {
            var fileName =Guid.NewGuid()+Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + fileName);
            var stream = new FileStream(path,FileMode.Create);
            await formFile.CopyToAsync(stream);
            return Created("",formFile);
        }
    }
}
