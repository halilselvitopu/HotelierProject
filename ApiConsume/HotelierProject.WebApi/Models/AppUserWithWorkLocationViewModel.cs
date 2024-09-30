﻿namespace HotelierProject.WebApi.Models
{
    public class AppUserWithWorkLocationViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkLocationName { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int WorkLocationId { get; set; }
    }
}
