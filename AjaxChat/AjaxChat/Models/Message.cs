using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxChat.Models
{
    public class Message
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string MsgText { get; set; }
        public List<Message> Messages { get; set; }

    }
}