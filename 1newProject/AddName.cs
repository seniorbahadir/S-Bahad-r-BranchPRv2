using _1newProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject
{
    public class AddName
    {
        
        public void AddUserName(UserModel.ReturnData userModelReturn)
        {

            userModelReturn.Name="Bahadır";

            AddMail addMail = new AddMail();
            addMail.AddUserMail(userModelReturn);
        }
    }
}
