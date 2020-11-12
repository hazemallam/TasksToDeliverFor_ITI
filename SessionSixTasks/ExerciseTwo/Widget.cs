using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Widget: IWidget
    {
        public virtual void First()
        {
            Console.WriteLine("First inside Widget");
        }
        void IWidget.Second()
        {
            Console.WriteLine("Second inside Widget");
        }
    }
}
