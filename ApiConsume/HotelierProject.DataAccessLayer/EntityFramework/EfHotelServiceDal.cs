﻿using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EfHotelServiceDal : GenericRepository<HotelService>, IHotelServiceDal
    {
        public EfHotelServiceDal(Context context) : base(context)
        {
        }
    }
}
