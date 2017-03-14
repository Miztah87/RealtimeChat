using ChatDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDAL.Context
{
    class DbConn : DbContext
    {
        public DbConn() : base("DefaultConnection")
        {
            //Seeds the data in the DB any time when the rest is started, in this case with nothing ( clears it ).
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Message> Messages { get; set; }
    }
}
