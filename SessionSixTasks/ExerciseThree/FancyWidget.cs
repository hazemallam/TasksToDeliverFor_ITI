using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class FancyWidget : Widget
    {
       
        protected override void First()
        {
            Console.WriteLine("First inside FancyWidget");
        }
        public void test()
        {
            First();
        }

    }
}
