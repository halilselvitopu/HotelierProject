using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelierProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;

namespace HotelierProject.WebUI.ViewComponents.AdminDashboard
{
    public class AdminDashboardSubscribeCountComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/microsoft"),
                Headers =
    {
        { "x-rapidapi-key", "4034e659c0msh83d8f6ae7d77004p134fffjsnf5fb44dbe656" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.followersCount = resultInstagramFollowersDto.followers;
                ViewBag.followingCount = resultInstagramFollowersDto.following;
                return View(resultInstagramFollowersDto);
            }
           
        }
    }
}
