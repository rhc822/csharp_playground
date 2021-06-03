using System;
using System.Collections;

namespace c_sharp_playground
{
    class Program
    {

        static void Main()
        {
            //Console.WriteLine("Enter Value1");
            //double value1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Value2");
            //double value2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();


            var Methods = new Methods();
            Console.WriteLine(Methods.MethodOverloadingExample("Chloe", "Pilkerton", "CEO", 20));
            // Methods.MethodsExample1(test4: 1.234, test3: 21, test: "Bob"); // Named arguemnts enables them to occur in any position in the method call

        }

        
    }
}
