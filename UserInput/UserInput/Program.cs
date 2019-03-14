using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine("The sum of number 1 and number 2 ... " + sum);

            Console.Read();
        }
    }
}
