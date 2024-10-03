using HotelierProject.WebUI.Dtos.AdminBookingDto;
using HotelierProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.ViewComponents.AdminDashboard
{
    public class AdminDashboardGetLastBookings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminDashboardGetLastBookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27314/api/Booking/GetLastBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLastBookingsDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
