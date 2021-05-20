using System;


namespace c_sharp_playground
{
    class MathMethods
    {
        public double _num1;
        public double _num2;
       public MathMethods(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public void MathActivelyWorkingOn()
        {

        }

        public void MathExamples()
        {
            Console.WriteLine($"Max value is {Math.Max(_num1, _num2)}");
            Console.WriteLine($"Min value is {Math.Min(_num1, _num2)}");
            Console.WriteLine($"Absolute value is {Math.Abs(_num1)}");
            Console.WriteLine($"Rounded number is {Math.Round(_num1)}");
            Console.WriteLine($"Square root of number is {Math.Sqrt(_num1)}");
        }

    }
}
