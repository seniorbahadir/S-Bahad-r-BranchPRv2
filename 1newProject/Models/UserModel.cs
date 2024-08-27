using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject.Models
{
    public class UserModel
    {
      public class Return
        {
            public ReturnData? Data { get; set; }
        }
        public class ReturnData
        {
            public int? Age { get; set; }
            public string? Name { get; set; }
            public string? Mail { get; set; }
        }

        public class Request
        {
            public string? TCNumber { get; set; }
        }
    }
    
}
