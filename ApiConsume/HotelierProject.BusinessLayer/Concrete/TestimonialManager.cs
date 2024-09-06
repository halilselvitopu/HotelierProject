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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void DeleteT(Testimonial t)
        {
           _testimonialDal.Delete(t);
        }

        public Testimonial GetByIdT(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetListT()
        {
           return _testimonialDal.GetAll();
        }

        public void InsertT(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void UpdateT(Testimonial t)
        {
           _testimonialDal.Update(t);
        }
    }
}
