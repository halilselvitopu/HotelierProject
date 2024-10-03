using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void ChangeBookingStatusToApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.Id == booking.Id).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
            

        }

        public void ChangeBookingStatusToApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

         public List<Booking> GetLastBookings()
        {
            var context = new Context();
            return context.Bookings.OrderByDescending(x => x.Id).Take(8).ToList();
        }
    }
}
