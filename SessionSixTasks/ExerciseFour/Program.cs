using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            IWidget w = new Widget();
            w.First();
            w.Second();
            Console.ReadKey();
            
        }
    }
}
