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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void DeleteT(About t)
        {
            _aboutDal.Delete(t);
        }

        public About GetByIdT(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetListT()
        {
            return _aboutDal.GetAll();
        }

        public void InsertT(About t)
        {
            _aboutDal.Insert(t);
        }

        public void UpdateT(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
