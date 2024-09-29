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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void DeleteT(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation GetByIdT(int id)
        {
            return _workLocationDal.GetById(id);
        }

        public List<WorkLocation> GetListT()
        {
            return _workLocationDal.GetAll();
        }

        public void InsertT(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void UpdateT(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
