using System;
using System.Collections;

namespace c_sharp_playground
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a value");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another value");
            double value2 = Convert.ToDouble(Console.ReadLine());
            Operators Operators = new Operators(value1, value2);
            Operators.OperatorActivelyWorkingOn();

            // var UserInput = new UserInput();
            // UserInput.UserInputProgram();
            //WriteLine("hello");
            //var dataTypes = new DataTypes();
            //dataTypes.DataTypeExamples();
            //var typeCasting = new TypeCasting();
            //typeCasting.TypeCastingExamples(); 

        }
    }
}
