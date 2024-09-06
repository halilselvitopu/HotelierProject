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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void DeleteT(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public Newsletter GetByIdT(int id)
        {
           return _newsletterDal.GetById(id);
        }

        public List<Newsletter> GetListT()
        {
           return  _newsletterDal.GetAll();
        }

        public void InsertT(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void UpdateT(Newsletter t)
        {
            _newsletterDal.Update(t);
        }
    }
}
