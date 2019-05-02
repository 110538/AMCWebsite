using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMC_Demo.Models
{
    public class ApiJsonResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }
    }

    public class TokenResult
    {
        public string access_token { get; set; }
        public string token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
    }
}
