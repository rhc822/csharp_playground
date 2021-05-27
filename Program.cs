using System;
using System.Collections;

namespace c_sharp_playground
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Value1");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value2");
            double value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            WhileLoops WhileLoops = new WhileLoops(value1, value2);
            WhileLoops.WhileLoopWorkInProgress();
            //ForLoop ForLoop = new ForLoop(value1, value2);
            //ForLoop.ForLoopWIP();

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
