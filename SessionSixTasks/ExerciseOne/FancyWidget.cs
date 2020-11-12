using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class FancyWidget : Widget
    {
        public FancyWidget() : base()
        {

        }
        public override void First()
        {
            Console.WriteLine("First inside FancyWidget");
        }
        public new void Second()
        {
            Console.WriteLine("Second inside FancyWidget");
        }
    }
}
