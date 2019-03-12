using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exercise_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            int dwarf = sevenDwarves.Length;
            string[] drink = new string[dwarf];
            string[] dinner = new string[dwarf];

            for (int i = 0; i < dwarf; i++)
            {
                Console.WriteLine(sevenDwarves[i]+ ", what do you want to drink?");
                drink[i] = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(sevenDwarves[i] + ", what do you want for dinner?");
                dinner[i] = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(sevenDwarves[i] + ", your " + drink[i] + " is ready!");
                Console.WriteLine("");
                Console.WriteLine(sevenDwarves[i] + ", your " + dinner[i] + " is ready!");
            }

           Console.Read();
        }
    }
}