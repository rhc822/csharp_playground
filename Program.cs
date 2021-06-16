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

            // ENUMS
            EnumTest test = EnumTest.high; // Assign to variable
            //Console.WriteLine($"Accessing the enum as it's own 'class': {test}");
            //Console.WriteLine($"enum value is: {(int) test}\nand it's type is: {test.GetType()}"); // 
            //EnumTestClass test2 = new EnumTestClass(); // Enums in classes are static and you can't access them through instantiation
            //Console.WriteLine($"Accessing the enum inside another class: {(int) EnumTestClass.Dates.June}\nand it's type is: {EnumTestClass.Dates.December.GetTypeCode()}"); // Must use the whole path to access the 
            switch (test)
            {
                case EnumTest.low:
                    Console.WriteLine("The chlorine levels are low. You're gonna have algae problems brother.");
                    break;
                case EnumTest.medium:
                    Console.WriteLine("The chlorine levels are medium. Have a good time and enjoy the pool. It's fun.");
                    break;
                case EnumTest.high:
                    Console.WriteLine("The chlorine levels are too high. Get out of the pool or you will die!");
                    break;
            }


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
