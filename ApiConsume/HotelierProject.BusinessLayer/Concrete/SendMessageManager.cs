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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void DeleteT(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage GetByIdT(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> GetListT()
        {
            return _sendMessageDal.GetAll();
        }

        public void InsertT(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void UpdateT(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
