using _1newProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject.Data
{
    public class UserData
    {
        public void AddTcNumber(UserModel.Request userModelRequest)
        {
            userModelRequest.TCNumber = "12345678901";
              
        }

    }
}
