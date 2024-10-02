using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.ViewComponents.AdminDashboard
{
    public class AdminDashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminDashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
           var client = _httpClientFactory.CreateClient();
           var responseMessage = await client.GetAsync("http://localhost:27314/api/DashboardWidgets/GetStaffCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.v = jsonData;
                
            }

            return View();
        }
    }
}
