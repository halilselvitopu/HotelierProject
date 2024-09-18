using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;
public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void DeleteT(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest GetByIdT(int id)
        {
           return _guestDal.GetById(id);
        }

        public List<Guest> GetListT()
        {
           return _guestDal.GetAll();
        }

        public void InsertT(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void UpdateT(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
