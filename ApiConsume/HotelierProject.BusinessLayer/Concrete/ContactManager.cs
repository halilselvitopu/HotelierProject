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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void DeleteT(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetByIdT(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListT()
        {
            return _contactDal.GetAll();
        }

        public void InsertT(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void UpdateT(Contact t)
        {
            _contactDal.Update(t);  
        }
    }
}
