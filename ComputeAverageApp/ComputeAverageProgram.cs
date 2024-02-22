using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");
            int grades1 = Convert.ToInt32(Console.ReadLine());
            int grades2 = Convert.ToInt32(Console.ReadLine());
            int grades3 = Convert.ToInt32(Console.ReadLine());
            int grades4 = Convert.ToInt32(Console.ReadLine());
            int grades5 = Convert.ToInt32(Console.ReadLine());

            double total = grades1 + grades2 + grades3 + grades4 + grades5;
            double average = total / 5;
            double roundOff = Math.Round(average);

            Console.WriteLine("The average is " + average + " round off to " + roundOff);           
            Console.WriteLine("\nPress any key to exit...");            
            Console.ReadKey();
        }
    }
}
