using ChatDAL.Context;
using ChatDAL.DomainModel;
using ChatDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDAL.Repository
{
    public class MessageRepository : IRepository<Message>
    {
        public void Add(Message msg)
        {
            using (var ctx = new DbConn())
            {
                ctx.Messages.Add(msg);
                ctx.SaveChanges();
            }
        }

        public List<Message> ReadAll()
        {
            using (var ctx = new DbConn())
            {
                return ctx.Messages.ToList();
            }
        }
    }
}
