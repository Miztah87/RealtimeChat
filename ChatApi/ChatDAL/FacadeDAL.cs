using ChatDAL.DomainModel;
using ChatDAL.Repository;
using ChatDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDAL
{
    
    public class FacadeDAL
    {
        private IRepository<Message> messageRepo;
        public IRepository<Message> GetMessageRepository()
        {
            if (messageRepo == null)
            {
                messageRepo = new MessageRepository();
            }
            return messageRepo;
        }
    }
}
