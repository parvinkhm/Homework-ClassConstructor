using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_2.Models
{
    internal class Student
    {
        public string fullName;
        public string address;
        public int age;

        public string GetFullData()
        {


            Book book = new Book();
            book.ShowAdvert();

            return $"Fullname: {fullName}, Address {address}, Age {age}";}
        }
    }
}
