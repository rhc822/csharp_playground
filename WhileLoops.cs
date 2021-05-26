using System;


namespace c_sharp_playground
{
    class WhileLoops
    {
        public double _value1;
        public double _value2;

        public WhileLoops(double value1, double value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void WhileLoopWorkInProgress()
        {

        }

        public void WhileLoopExample()
        {
            while ((_value1 + _value2)< 100)
            {
                Console.WriteLine("The sum of the values must be GREATER THAN 100.");
                Console.WriteLine("Enter Value1");
                _value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Value2");
                _value2 = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void DoWhileExample()
            {
                do // This is going to execute anyway regardless of values
                {
                    Console.WriteLine($"Value1 + Value2 = {_value1 + _value2}\n");
                    Console.WriteLine("Enter Value1");
                    _value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Value2");
                    _value2 = Convert.ToDouble(Console.ReadLine());
                }
                while ((_value1 + _value2) < 100);
            }
    }
}
