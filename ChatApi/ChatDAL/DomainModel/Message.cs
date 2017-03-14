using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDAL.DomainModel
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
      //  public DateTime Date { get; set; }
        public string MsgText { get; set; }
    }
}
