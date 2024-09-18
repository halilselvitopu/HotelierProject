using HotelierProject.WebUI.Dtos.AdminBookingDto;
using HotelierProject.WebUI.Dtos.HotelServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27314/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAdminBookingDto>>(jsonData);
                return View(values);
            }
            return View();
            
        }

        public async Task<IActionResult> ApproveBooking(ApproveBookingDto approveBookingDto)
        {
            approveBookingDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(approveBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:27314/api/Booking/ApproveBooking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(jsonData);
        }
        public async Task<IActionResult> ApproveBooking2(ApproveBookingDto approveBookingDto)
        {
            approveBookingDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(approveBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:27314/api/Booking/ApproveBooking2", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(jsonData);
        }
    }
}
