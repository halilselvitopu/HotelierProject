using HotelierProject.WebUI.Dtos.HotelServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.ViewComponents.Default
{
    public class HotelServiceComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HotelServiceComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27314/api/HotelService");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultHotelServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
