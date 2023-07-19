using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework_2
{
    internal class Calculator
    {
       
        public void Num(string int1)
        {
            int result = 0;

            int res;
            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter symbol(/,+,-,*):");
            string symbol = Console.ReadLine();


            switch (symbol)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Addition:" + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Subtraction:" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Multiplication:" + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Division:" + result);
                    break;
                default:
                    Console.WriteLine("Not true operation");
                    break;
            }


        }
    }
    







    