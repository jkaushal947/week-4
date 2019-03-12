using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a score");
            int score;
            score = Convert.ToInt32(Console.ReadLine());
            if (score == 10)
            {
                Console.WriteLine("Wow! Top score!!");
            }
            else if ((score >= 5) && (score <= 9))
            {
                Console.WriteLine("Well done – you passed!");
            }
            else if ((score >= 10))
            {
                Console.WriteLine("Invalid Score!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn’t pass.");
            }
            Console.Read();
        }
    }
}
