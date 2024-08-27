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

        public void AddUserName(UserModel.ReturnData returnData)
        {

            returnData.Name = "Bahadır";

            AddMail addMail = new AddMail();
            addMail.AddUserMail(returnData);
        }
    }
}
