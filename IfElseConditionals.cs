using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class IfElseConditionals
    {
        public double _value1;
        public double _value2;
        
        public IfElseConditionals(double value1, double value2)
        {
            _value1 = value1;
            _value2 = value2;
        }
        public void IfElseConditionalsActivelyWorkingOn()
        {

        }
        public void IfElseConditionalsExamples()
        {
            if (_value1 > _value2)
            {
                Console.WriteLine($"{_value1} > {_value2}");
            }
            else if (_value1 < _value2)
            {
                Console.WriteLine($"{_value1} < {_value2}");
            }
            else if (_value1 == _value2)
            {
                Console.WriteLine($"{_value1} = {_value2}");
            }
            else
            {
                Console.WriteLine($"I don't know");
            }

            // "Short hand if" Ternary operator
            Console.WriteLine((_value1 > _value2) ? $"{_value1} > {_value2}" : $"{_value1} < {_value2}"); // If values are same, outputs 2nd (false) expression

        }

        public void SwitchExamples()
        {
            switch (_value1)
            {
                case 1:
                case 2:
                    Console.WriteLine($"You entered either a one or two.\n"); // Note case 1 will have same output as case 2 because no 'break' in case 1
                    break;
                case 3:
                    Console.WriteLine($"You entered a three.\n");
                    break;
                default:
                    Console.WriteLine($"Hi... This is the default text that is shown if you entered anything other than 1, 2, or 3...\n");
                    break;
            }
            Console.WriteLine("What about the lonely second value you entered? Here it is (using composite formatting! {0})\n", _value2);
            Console.WriteLine($"And here it is (using string interpolation)! {_value2}");
        }
    }
}
