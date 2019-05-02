using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMC_Demo.Models
{
    public class ErrorData
    {       
        public int Id { get; set; }
        public string MsgId { get; set; }
        public string Source_System { get; set; }
        public string Event { get; set; }
        public string Event_Transaction { get; set; }
        public string Bid { get; set; }
        public string RecordedOn { get; set; }       
        public string Message { get; set; }
    }

    public class MessageArray
    {

    }
}
