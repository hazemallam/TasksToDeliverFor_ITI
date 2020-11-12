using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWidget i = new Widget();
            i.First();
            i.Second();

            Console.ReadKey();
        }
    }
}
