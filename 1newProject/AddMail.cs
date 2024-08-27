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
        public UserModel.ReturnData AddUserAge(UserModel.ReturnData returnData)
        {
            returnData.Age = 24;
            return returnData;
        }
    }
}
