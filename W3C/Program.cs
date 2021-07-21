using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace c_sharp_playground
{
    class Program
    {

        static void Main()
        {

            // LINQ FUN
            LINQ.LinqExample();

            // TRY/CATCH FUN!
            // Throw keyword and custom error
            //Console.WriteLine("Enter Value1");
            //string value1 = Console.ReadLine();
            //checkValue1(value1);
            //static void checkValue1(string value1)
            //{
            //    string pattern = "[a-zA-Z]";
            //    Regex regex = new Regex(pattern);
            //    MatchCollection match = regex.Matches(value1);
            //    if (match.Count > 0)
            //    {
            //        throw new FormatException("Please, your life depends on you entering a number.");
            //    }
            //    else
            //    {
            //        Convert.ToInt32(value1);
            //    }
            //}
            //Console.WriteLine("Enter Value2");
            //string value2 = Console.ReadLine();
            //checkValue2(value2);
            //static void checkValue2(string value2)
            //{
            //    string pattern = "[a-zA-Z]";
            //    Regex regex = new Regex(pattern);
            //    MatchCollection match = regex.Matches(value2);
            //    if (match.Count > 0)
            //    {
            //        throw new FormatException("Please, your life depends on you entering a number.");
            //    }
            //    else
            //    {
            //        Convert.ToInt32(value2);
            //    }
            //}



            //int value1 = Convert.ToInt32(Console.ReadLine());
            //if (value1.)
            //{
            //    throw new FormatException ("You must enter a number.");
            //}
            //else
            //{
            //    Console.WriteLine("All clear. Enter numbers to your heart's content.");
            //}
            //try
            //{
            //    double value1 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("This is the 'finally' statement");
            //}
            //Console.WriteLine("Enter Value2");
            //int value2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            // FILE TEST
            //FileTest FileTest = new FileTest();
            //FileTest.FileTestCreation();
            //FileTest.FileFun();

            // ENUMS
            //EnumTest test = EnumTest.high; // Assign to variable
            //Console.WriteLine($"Accessing the enum as it's own 'class': {test}");
            //Console.WriteLine($"enum value is: {(int) test}\nand it's type is: {test.GetType()}"); // 
            //EnumTestClass test2 = new EnumTestClass(); // Enums in classes are static and you can't access them through instantiation
            //Console.WriteLine($"Accessing the enum inside another class: {(int) EnumTestClass.Dates.June}\nand it's type is: {EnumTestClass.Dates.December.GetTypeCode()}"); // Must use the whole path to access the 
            //switch (test)
            //{
            //    case EnumTest.low:
            //        Console.WriteLine("The chlorine levels are low. You're gonna have algae problems brother.");
            //        break;
            //    case EnumTest.medium:
            //        Console.WriteLine("The chlorine levels are medium. Have a good time and enjoy the pool. It's fun.");
            //        break;
            //    case EnumTest.high:
            //        Console.WriteLine("The chlorine levels are too high. Get out of the pool or you will die!");
            //        break;
            //}


            // INTERFACE
            //Console.WriteLine("Enter the animal name");
            //string animalName = Console.ReadLine();
            //Console.WriteLine("Enter the animal sound");
            //string animalSound = Console.ReadLine();
            //InterfaceImplementationClass interfaceImplementationClass = new InterfaceImplementationClass(animalName, animalSound);
            //interfaceImplementationClass.animalSound();

            // ABSTRACT
            //var myAbstractClass = new AbstractClass();


            // POLYMORPHISM
            //Console.WriteLine("Enter the make of the vehicle");
            //string make = Console.ReadLine();
            //Console.WriteLine("Enter the model of the vehicle");
            //string model = Console.ReadLine();
            //Class_BaseParent myPolymorphismExample1 = new Class_DerivedChild(model, make);
            //Console.WriteLine("Enter ANOTHER vehicle make");
            //make = Console.ReadLine();
            //Console.WriteLine("Enter ANOTHER vehicle model");
            //model = Console.ReadLine();
            //Class_BaseParent myPolymorphismExample2 = new Class_DerivedChild2(model, make);
            ////Class_BaseParent myPolymorphismBase = new Class_BaseParent();
            //Class_BaseParent myPolymorhismExample3 = new Class_DerivedChild3(model, make);
            ////Console.WriteLine($"You have won a/an {myPolymorphismExample1.Make} {myPolymorphismExample1._modelName} {myPolymorphismExample1.honk()}\nAND\na/an {myPolymorphismExample2.Make} {myPolymorphismExample2._modelName} {myPolymorphismExample2.honk()}");
            //// myPolymorphismBase.honk();
            //myPolymorphismExample1.honk();
            //myPolymorphismExample2.honk();
            //myPolymorhismExample3.honk();


            // CLASS PROPERTIES
            //Console.WriteLine("Enter a name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter an age");
            //int enteredAge = Convert.ToInt32(Console.ReadLine());

            //var Properties = new Properties();
            //Properties.Name = firstName;
            //Properties.Age = enteredAge;
            //Console.WriteLine($"Hello, I am '{Properties.Name}', and I am {Properties.Age}. I work at {Properties.Workplace}");

            //var Methods = new Methods();
            //Console.WriteLine(Methods.MethodOverloadingExample("Chloe", "Pilkerton", "CEO", 20));
            // Methods.MethodsExample1(test4: 1.234, test3: 21, test: "Bob"); // Named arguemnts enables them to occur in any position in the method call

        }


    }
}
