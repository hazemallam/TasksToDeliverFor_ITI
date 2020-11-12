using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget widget = new FancyWidget();
            widget.First();
            widget.Second();
            Console.ReadKey();
        }
    }
}
