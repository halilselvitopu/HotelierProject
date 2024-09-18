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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void ChangeBookingStatusToApprovedT2(int id)
        {
           _bookingDal.ChangeBookingStatusToApproved2(id);
        }

        public void ChangeBookingStatusToApprovedT(Booking booking)
        {
           _bookingDal.ChangeBookingStatusToApproved(booking);
        }

        public void DeleteT(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking GetByIdT(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> GetListT()
        {
            return _bookingDal.GetAll();
        }

        public void InsertT(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void UpdateT(Booking t)
        {
            _bookingDal.Update(t);  
        }
    }
}
