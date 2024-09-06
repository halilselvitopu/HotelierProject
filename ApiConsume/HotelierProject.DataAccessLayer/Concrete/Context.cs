﻿using HotelierProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-7BBVMRE\\SQLEXPRESS;initial catalog=HotelierDb;integrated security=true");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
