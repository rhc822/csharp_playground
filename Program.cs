using System;

namespace c_sharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /****************************************************
            
            Playing around with primitive data types
            
             ****************************************************/

            string firstName = "Slate"; // string
            Console.WriteLine("first name = " + firstName);
            string lastName = "SlamFish"; // another string
            Console.WriteLine("last name = " + lastName);
            string fullName = firstName + " " + lastName; //combined string
            Console.WriteLine("Full Name = " + fullName);

            int number = 123; // integer
            Console.WriteLine("number = " + number);
            int anotherNumber = 456;
            Console.WriteLine("anotherNumber = " + anotherNumber);
            Console.WriteLine(number + anotherNumber); // When concatenating two variables holding integers, the result is addition, unless....
            Console.WriteLine("Combined numbers = " + number + anotherNumber); // you have a string in the mix, then it simply puts them together, unless...
            Console.WriteLine("Combined numbers = " + (number + anotherNumber)); // you put parentheses around the two integers in the expression

            // Declare many variables of the same type
            int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6;
            Console.WriteLine(a + b + c + d + e + f);

            const double constantNumber = 3.14;
            Console.WriteLine("constantNumber = " + constantNumber);

            // variable delcared but unassigned variable
            string something; 
            // variable now assigned
            something = "Something is assigned";
            Console.WriteLine("The first 'something' = " + something);
            // variable now re-assigned
            something = "Something ELSE is assigned. It's another string.";
            Console.WriteLine("The second, or re-assigned 'something' = " + something);

            bool myBoolean = true;
            Console.WriteLine("boolean currently = " + myBoolean);
            myBoolean = false;
            Console.WriteLine("boolean currently = " + myBoolean);
        }
    }
}
