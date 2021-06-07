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
            Console.WriteLine("Enter a name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter an age");
            int enteredAge = Convert.ToInt32(Console.ReadLine());

            var Properties = new Properties();
            Properties.Name = firstName;
            Properties.Age = enteredAge;
            Console.WriteLine($"Hello, I am '{Properties.Name}', and I am {Properties.Age}. I work at {Properties.Workplace}");

            //var Methods = new Methods();
            //Console.WriteLine(Methods.MethodOverloadingExample("Chloe", "Pilkerton", "CEO", 20));
            // Methods.MethodsExample1(test4: 1.234, test3: 21, test: "Bob"); // Named arguemnts enables them to occur in any position in the method call

        }

        
    }
}
