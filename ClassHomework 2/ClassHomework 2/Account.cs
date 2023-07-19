using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework_2
{
    internal class Account
    {
        public void Login(string username, string password)
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Login successes");
            }
            else
            {
                Console.WriteLine("Username or password is wrong");
            }
        }
    }

}
