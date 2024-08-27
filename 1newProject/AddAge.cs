using _1newProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject
{
    public class AddAge
    {
        public void AddUserAge(UserModel.ReturnData userModelReturn)
        {
            userModelReturn.Age= 24;

            Console.WriteLine(userModelReturn.Name);
            Console.WriteLine(userModelReturn.Mail);
            Console.WriteLine(userModelReturn.Age);
            
        }
    }
}
