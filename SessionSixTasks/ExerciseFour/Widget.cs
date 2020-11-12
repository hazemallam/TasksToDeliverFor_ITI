using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFour
{
    sealed class Widget : IWidget
    {
        void IWidget.First()
        {
            Console.WriteLine("First inside Widget");
        }
        void IWidget.Second()
        {
            Console.WriteLine("Second inside Widget");
        }
    }
}
