using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void ChangeBookingStatusToApproved(int id);
        void ChangeBookingStatusToCancel(int id);
        int GetBookingCount();
        List<Booking> GetLastBookings();
    }
}
