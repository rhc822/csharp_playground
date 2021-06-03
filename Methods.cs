using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class Methods
    {
        public void MethodsWIP()
        {
            
        }

        public void MethodsExample1(string test, int test2, double test3, string test4 = "default string test") // "optional" parameters must go after required parameters
        {
            Console.WriteLine($"Hi I am {test}, and I am {test2} years old.\nI also want to say,\"{test4}\".\nHere's a double value for good measure {test3}");
        }

        //Return two values, not able to console.writeline in method definition because expecting an "int" to be returned
        public int MethodsExample2(int a, int b)
        {
            return a + b;
        }

        // Specifying/using/implementing only one deafult parameter
        public void MethodsExample3(string test = "Zippy", int test2 = 1, double test3 = 3.14, string test4 = "I'm the original default string")
        {
            Console.WriteLine(test4);
        }

        public string MethodOverloadingExample()
        {
            return "You didn't enter anything silly";
        }

        public string MethodOverloadingExample(string firstName)
        {
            return firstName;
        }

        public string MethodOverloadingExample(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string MethodOverloadingExample(string firstName, string lastName, string occupation)
        {
            return $"{firstName} {lastName} is a/an {occupation}";
        }

        public string MethodOverloadingExample(string firstName, string lastName, string occupation, int yearsActive)
        {
            return $"{firstName} {lastName} has been a/an {occupation} for {yearsActive} years";
        }

    }
}
