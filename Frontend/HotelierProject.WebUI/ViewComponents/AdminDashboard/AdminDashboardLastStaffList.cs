using HotelierProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.ViewComponents.AdminDashboard
{
    public class AdminDashboardLastStaffList : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminDashboardLastStaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27314/api/Staff/LastStaffList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLastStaffListDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
