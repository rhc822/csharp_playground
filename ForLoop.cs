using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{

    /****************************************************

    Playing around with for loops

    ****************************************************/

    class ForLoop
    {
        public double _value1;
        public double _value2;

        public ForLoop(double value1, double value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void ForLoopWIP()
        {
            // TODO: when I go through the array chapter, come back here and play with foreach()
            //foreach()


 

        }
        public void ForLoopExamples()
        {
            // An example of assinging variable to itself because for loop requires 1st statement be a variable declaration
            for (_value1 = _value1; _value1 < 50; _value1++)
            {
                Console.WriteLine($"Value1 is currently {_value1}");
            }

            // "Standard" way handling a for loop using an input value
            for (double i = _value1; i < 50; i++)
            {
                Console.WriteLine($"Value1 is currently {i}");
            }

            // for loop "continue" and "break"
            for (double i = _value1; i < 50; i++)
            {
                Console.WriteLine($"Value1 is currently {i}");
                if (i == 34)
                {
                    Console.WriteLine("CONTINUE past 34!");
                    continue;
                }

                if (i == 45)
                {
                    break;
                }
            }


        }


    }
}
