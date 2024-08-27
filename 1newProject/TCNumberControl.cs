using _1newProject.Data;
using _1newProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject
{
    public class TCNumberControl
    {
        
        public void Compare(string TcNumber,UserModel.Request userModel)
        {
            if (TcNumber == userModel.TCNumber)
            {
               
                UserModel.ReturnData returnData = new UserModel.ReturnData
                {
                    Age = null,
                    Name = null,
                    Mail = null
                };

                AddName addName = new AddName();
                addName.AddUserName(returnData);
            }
            else
            {
                Console.WriteLine("TC Bulunamadı");
            }
        }
    }
}
