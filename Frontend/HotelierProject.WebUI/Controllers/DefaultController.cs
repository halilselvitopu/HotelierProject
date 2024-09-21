using HotelierProject.WebUI.Dtos.NewsletterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<PartialViewResult> NewsletterPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> NewsletterPartial(CreateNewsletterDto createNewsletterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createNewsletterDto);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:27314/api/Newsletter",stringContent);
             
            return RedirectToAction("Index","Default");
        
        }
    }
}
