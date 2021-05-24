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

    }
}
