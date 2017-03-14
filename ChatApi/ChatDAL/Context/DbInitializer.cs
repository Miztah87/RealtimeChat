using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDAL.Context
{
    class DbInitializer : DropCreateDatabaseAlways<DbConn>
    {
        protected override void Seed(DbConn context)
        {

        }
    }
}
