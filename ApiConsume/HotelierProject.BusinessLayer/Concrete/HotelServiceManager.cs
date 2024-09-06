using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class HotelServiceManager : IHotelServiceService
    {

        private readonly IHotelServiceDal _hotelServiceDal;

        public HotelServiceManager(IHotelServiceDal hotelServiceDal)
        {
            _hotelServiceDal = hotelServiceDal;
        }

        public void DeleteT(HotelService t)
        {
            _hotelServiceDal.Delete(t);
        }

        public HotelService GetByIdT(int id)
        {
            return _hotelServiceDal.GetById(id);
        }

        public List<HotelService> GetListT()
        {
            return _hotelServiceDal.GetAll();
        }

        public void InsertT(HotelService t)
        {
            _hotelServiceDal.Insert(t);
        }

        public void UpdateT(HotelService t)
        {
            _hotelServiceDal.Update(t);
        }
    }
}
