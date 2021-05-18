using System;


namespace c_sharp_playground
{
    class Operators
    {

        public int _num;
        public double _numConvertToDouble;

        public Operators(int num, double numConvertToDouble)
        {

            _num = num;
            _numConvertToDouble = numConvertToDouble;

        }

        public void OperatorActivelyWorkingOn()
        {



        }

        public void OperatorExamples()
        {
            /****************************************************

            Playing around with Operators

            ****************************************************/

            Console.WriteLine("Numbers Starts with this value: " + _num);
            _num -= 25;
            Console.WriteLine("Subtract 25... " + _num);
            _num *= 3;
            Console.WriteLine("Multiply by 3... " + _num);
            Console.WriteLine("Data Type of 'num' is: " + _num.GetTypeCode());


            _num /= 7;
            _numConvertToDouble /= 7;
            Console.WriteLine("Divide 'num' by 7... " + _num); // Calculator says answer is 53.57142..., but...
            Console.WriteLine("Data Type of 'num' is: " + _num.GetTypeCode()); // it's interesting keeps it Int32 and rounds down to 53
            Console.WriteLine("Divide 'numConvertToDouble' by 7... " + _numConvertToDouble); // Same as Calculator
            Console.WriteLine("Data Type of 'numConvertToDouble' is: " + _numConvertToDouble.GetTypeCode());

            Console.WriteLine();

            // Modulo
            Console.WriteLine("MODULO");
            var modulo = _num % 9.99;
            Console.WriteLine(modulo);
            Console.WriteLine(modulo.GetTypeCode());

            Console.WriteLine();

            // Increment/Decrement
            Console.WriteLine("INCREMENT/DECREMENT");
            _num++;
            Console.WriteLine((_num)); // Doesn't DISPLAY the increment by one on this line even though it increment
            _num--;
            _num--;
            _num--;
            _num--;
            Console.WriteLine((_num));
            
            Console.WriteLine();

            // TODO: Other assignment operators: &=, |=, ^=, >>=, <<= are explicitly bitwise operators, and I don't understand them

            // Comparison operators
            Console.WriteLine("COMPARISON OPERATORS");
            Console.WriteLine($"_num initial value: {_num} and initial type: {_num.GetTypeCode()}");
            Console.WriteLine($"_numConvertToDouble initial value: {_numConvertToDouble} and initial type: {_numConvertToDouble.GetTypeCode()}");
            Console.WriteLine($"_num == _numConvertToDouble? {_num == _numConvertToDouble}");
            Console.WriteLine($"_num != _numConvertToDouble? {_num != _numConvertToDouble}");
            Console.WriteLine($"_num > _numConvertToDouble? {_num > _numConvertToDouble}");
            Console.WriteLine($"_num < _numConvertToDouble? {_num < _numConvertToDouble}");
            Console.WriteLine($"_num >= _numConvertToDouble? {_num >= _numConvertToDouble}");
            Console.WriteLine($"_num <= _numConvertToDouble? {_num <= _numConvertToDouble}");

            Console.WriteLine();

            // Logical operators
            Console.WriteLine("LOGICAL OPERATORS");
            Console.WriteLine($"Value1 > 100 && Value2 < 500: {_num > 100 && _numConvertToDouble < 500}");
            Console.WriteLine($"Value1 > 100 || Value2 < 500: {_num > 100 || _numConvertToDouble < 500}");
            Console.WriteLine($"!(Value1 > 100 && Value2 < 500): {!(_num > 100 && _numConvertToDouble < 500)}");

            // Adding a double and an int implicitly converts to double
            Console.WriteLine("IMPLICIT CONVERSION OF ADDING DOUBLE AND INT");
            var result = _numConvertToDouble + _num;
            Console.WriteLine("Data type of 'result' is: " + result.GetTypeCode());
            Console.WriteLine("Value of 'result' is: " + result);

            Console.WriteLine();

            // Assigning a string and int to a var variable will coerce to string
            var result2 = Convert.ToString(_num) + _num;
            Console.WriteLine("Data Type of 'result2' is: " + result2.GetTypeCode());
            Console.WriteLine("Value of 'result2' is: " + result2);



        }
    }
}
