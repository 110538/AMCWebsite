using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMC_Demo.Models
{
    public class DevOpsStatusTable
    {
        public int Id { get; set; }
        public string UI { get; set; }
        public bool Developement { get; set; }
        public bool Testing { get; set; }
        public bool Staging { get; set; }
        public bool Production { get; set; }
    }
}