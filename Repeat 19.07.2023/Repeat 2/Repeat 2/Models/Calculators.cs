using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_2.Models
{
    internal class Calculators
    {
        public int num1;
        public int num2;

        public Calculators()
        {

        }

        public Calculators(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public void Sum()    
        {
            int sum = 0;

            for (int i = num1; i < num2; i++)
            {
                sum += 1;
            }

            Console.WriteLine("Sum of numbers:" + sum);
        }
    }
}
