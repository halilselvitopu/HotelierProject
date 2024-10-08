﻿using HotelierProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        int GetStaffCountT();
        List<Staff> LastStaffListT();
    }
}
