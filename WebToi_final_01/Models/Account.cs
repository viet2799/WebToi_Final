using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebToi_final_01.Models
{
        public class Account
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public List<string> Roles { get; set; }
        }
    }