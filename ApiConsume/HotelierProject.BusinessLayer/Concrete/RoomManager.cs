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
    public class RoomManager : IRoomService
    {

         private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void DeleteT(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room GetByIdT(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> GetListT()
        {
            return _roomDal.GetAll();
        }

        public void InsertT(Room t)
        {
            _roomDal.Insert(t);
        }

        public void UpdateT(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
