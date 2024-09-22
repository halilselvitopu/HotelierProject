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
    public class MessageCategoryManager : IMessageCategoryService   
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void DeleteT(MessageCategory t)
        {
            _messageCategoryDal.Delete(t);
        }

        public MessageCategory GetByIdT(int id)
        {
            return _messageCategoryDal.GetById(id);
        }

        public List<MessageCategory> GetListT()
        {
            return _messageCategoryDal.GetAll();
        }

        public void InsertT(MessageCategory t)
        {
            _messageCategoryDal.Insert(t);
        }

        public void UpdateT(MessageCategory t)
        {
            _messageCategoryDal.Update(t);
        }
    }
}
