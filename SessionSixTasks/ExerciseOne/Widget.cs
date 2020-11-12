using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class Widget
    {
        public virtual void First()
        {
            Console.WriteLine("First inside widget");
        }
        public void Second()
        {
            Console.WriteLine("Second inside widget");
        }
    }
}
