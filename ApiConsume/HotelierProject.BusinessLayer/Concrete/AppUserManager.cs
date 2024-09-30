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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void DeleteT(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public AppUser GetByIdT(int id)
        {
            return _appUserDal.GetById(id);
        }

        public List<AppUser> GetListT()
        {
            return _appUserDal.GetAll();
        }

        public List<AppUser> GetUsersWithLocationsT()
        {
            return _appUserDal.GetUsersWithLocations();
        }

        public List<AppUser> GetUsersWithLocationT()
        {
           return _appUserDal.GetUsersWithLocation();
        }

        public void InsertT(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void UpdateT(AppUser t)
        {
            _appUserDal.Update(t);
        }
    }
}
