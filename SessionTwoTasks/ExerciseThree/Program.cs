using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils utils = new Utils();
            Console.WriteLine("year : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("day : ");
            int day = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} Leap Year.", year);
                utils.Leap(day);
            }
                
            else
            {
                Console.WriteLine("{0} not a Leap Year.", year);
                utils.NotLeap(day);

            }

            
        }
        
    }
}
