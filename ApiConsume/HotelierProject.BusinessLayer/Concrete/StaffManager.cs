﻿using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void DeleteT(Staff t)
        {
           _staffDal.Delete(t);
        }

        public Staff GetByIdT(int id)
        {
           return _staffDal.GetById(id);
        }

        public List<Staff> GetListT()
        {
            return _staffDal.GetAll();
        }

        public void InsertT(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void UpdateT(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
