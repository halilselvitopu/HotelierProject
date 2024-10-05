using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void ChangeBookingStatusToApprovedT(int id);
        void ChangeBookingStatusToCancelT(int id);
        void ChangeBookingStatusToCallT(int id);
        int GetBookingCountT();
        List<Booking> GetLastBookingsT();
    }
}
