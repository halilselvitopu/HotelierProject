using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void InsertT(T t);
        void DeleteT(T t);
        void UpdateT(T t);
        List<T> GetListT();
        T GetByIdT(int id);

    }
}
