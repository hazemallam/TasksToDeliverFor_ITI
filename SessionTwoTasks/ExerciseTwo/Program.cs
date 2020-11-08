using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int day = int.Parse(Console.ReadLine());
                int output = 0;
                if (day < 1 || day > 365)
                    throw new InvalidDataException("invalid argument");
                if (day >= 1 && day <= 31)
                {
                    Console.WriteLine("{0} January", day);
                }
                else if (day > 31 && day <= 59)
                {
                    output = day - 31;
                    Console.WriteLine("{0} February", output);
                }
                else if (day > 59 && day <= 90)
                {
                    output = day - 59;
                    Console.WriteLine("{0} March", output);
                }
                else if (day > 90 && day <= 120)
                {
                    output = day - 90;
                    Console.WriteLine("{0} April", output);
                }
                else if (day > 120 && day <= 151)
                {
                    output = day - 120;
                    Console.WriteLine("{0} May", output);
                }
                else if (day > 151 && day <= 181)
                {
                    output = day - 151;
                    Console.WriteLine("{0} June", output);
                }
                else if (day > 181 && day <= 212)
                {
                    output = day - 181;
                    Console.WriteLine("{0} July", output);
                }
                else if (day > 212 && day <= 242)
                {
                    output = day - 212;
                    Console.WriteLine("{0} August", output);
                }
                else if (day > 242 && day <= 273)
                {
                    output = day - 242;
                    Console.WriteLine("{0} September", output);
                }
                else if (day > 273 && day <= 303)
                {
                    output = day - 273;
                    Console.WriteLine("{0} October", output);
                }
                else if (day > 303 && day <= 334)
                {
                    output = day - 303;
                    Console.WriteLine("{0} November", output);
                }
                else if (day > 334 && day <= 365)
                {
                    output = day - 334;
                    Console.WriteLine("{0} December", output);
                }
                Console.ReadKey();

            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            


        }
    }
}
