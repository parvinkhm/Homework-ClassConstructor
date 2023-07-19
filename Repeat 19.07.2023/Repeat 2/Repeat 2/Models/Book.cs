using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_2.Models
{
    internal class Book
    {
        public string name;
        public string autor;
        public string pageCount;

        public void ShowAdvert()
        {
            int a = 5;
            string b = "Welcome";
            Console.WriteLine("Advertisment" + a + b);
        }

    }
}
