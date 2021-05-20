using System;


namespace c_sharp_playground
{
    class Operators
    {

        public int _num1;
        public int _num2;

        public Operators(int num1, int num2)
        {

            _num1 = num1;
            _num2 = num2;

        }

        public void OperatorActivelyWorkingOn()
        {



        }

        public void OperatorExamples()
        {
            /****************************************************

            Playing around with Operators

            ****************************************************/

            Console.WriteLine($"_num1 initial value: {_num1} and initial type: {_num1.GetTypeCode()}");
            Console.WriteLine($"_num2 initial value: {_num2} and initial type: {_num2.GetTypeCode()}");
            _num1 -= 25;
            Console.WriteLine("Subtract 25... " + _num1);
            _num1 *= 3;
            Console.WriteLine("Multiply by 3... " + _num1);
            Console.WriteLine("Data Type of 'num' is: " + _num1.GetTypeCode());


            _num1 /= 7;
            _num2 /= 7;
            Console.WriteLine("Divide 'num' by 7... " + _num1); // Calculator says answer is 53.57142..., but...
            Console.WriteLine("Data Type of 'num' is: " + _num1.GetTypeCode()); // it's interesting keeps it Int32 and rounds down to 53
            Console.WriteLine("Divide '_num2' by 7... " + _num2); // Same as Calculator
            Console.WriteLine("Data Type of '_num2' is: " + _num2.GetTypeCode());

            Console.WriteLine();

            // Modulo
            Console.WriteLine("MODULO");
            var modulo = _num1 % 9.99;
            Console.WriteLine(modulo);
            Console.WriteLine(modulo.GetTypeCode());

            Console.WriteLine();

            // Increment/Decrement
            Console.WriteLine("INCREMENT/DECREMENT");
            _num1++;
            Console.WriteLine((_num1)); // Doesn't DISPLAY the increment by one on this line even though it increment
            _num1--;
            _num1--;
            _num1--;
            _num1--;
            Console.WriteLine((_num1));
            
            Console.WriteLine();

            // TODO: Other assignment operators: &=, |=, ^=, >>=, <<= are explicitly bitwise operators, and I don't understand them

            // Comparison operators
            Console.WriteLine("COMPARISON OPERATORS");
            Console.WriteLine($"_num1 == _num2? {_num1 == _num2}");
            Console.WriteLine($"_num1 != _num2? {_num1 != _num2}");
            Console.WriteLine($"_num1 > _num2? {_num1 > _num2}");
            Console.WriteLine($"_num1 < _num2? {_num1 < _num2}");
            Console.WriteLine($"_num1 >= _num2? {_num1 >= _num2}");
            Console.WriteLine($"_num1 <= _num2? {_num1 <= _num2}");

            Console.WriteLine();

            // Logical operators
            Console.WriteLine("LOGICAL OPERATORS");
            Console.WriteLine($"Value1 > 100 && Value2 < 500: {_num1 > 100 && _num2 < 500}");
            Console.WriteLine($"Value1 > 100 || Value2 < 500: {_num1 > 100 || _num2 < 500}");
            Console.WriteLine($"!(Value1 > 100 && Value2 < 500): {!(_num1 > 100 && _num2 < 500)}");

            Console.WriteLine();


        }
    }
}
