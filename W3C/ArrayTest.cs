using System;
using System.Linq; // Adds additional array method options

namespace c_sharp_playground
{
    class ArrayTest
    {
        public void ArraysWIP()
        {

            Console.WriteLine("Arrays are of a fixed size. How big do you want your array; that is, how many index positions?");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string[] myArray = new string[arraySize];
            string answer = "";

            do
            {
                
                Console.WriteLine($"Array currently contains the following items:");
                foreach(string item1 in myArray)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine($"Do you want to add a value to the array? Enter 'y' for yes or 'n' for no");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Enter the item you want to add to the array");
                    string itemToAdd = Console.ReadLine();
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (myArray[i] == null)
                        {
                            myArray[i] = itemToAdd;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (answer == "n")
                {
                    Array.Sort(myArray);
                    Console.WriteLine($"This array contains 'bob'? {myArray.Contains("bob")}");
                    foreach(string item2 in myArray)
                    {
                        Console.WriteLine(item2);
                    }
                    
                    break;
                }
                else
                {
                    Console.WriteLine("You entered an invalid option");
                }
            }
            while (answer == "y");

        }

        public void ArraysExamples()
        {
            // Arrays must contain all the same type of declared items (conversion works though)
            string[] stringArrayTest = { "test", "things", "stuff", Convert.ToString(10) };
            Console.WriteLine($"Index position 3 is {stringArrayTest[3]} and it is of type '{stringArrayTest[3].GetTypeCode()}'");
            int[] intArrayTest = { 1, 2, 3, 4, Convert.ToInt32("5") };
            Console.WriteLine($"Index position 3 is {intArrayTest[4]} and it is of type '{intArrayTest[4].GetTypeCode()}'");

            // Add an item to a specific index position
            Console.WriteLine($"Index position 0 is currently '{stringArrayTest[0]}'");
            stringArrayTest[0] = "MODIFY ARRAY INDEX POSITION VALUE";
            Console.WriteLine($"Now index position 0 is '{stringArrayTest[0]}'");

            // Test declaring arrays
            string[] declareArrayTest1 = new string[4]; // Declare with array size, 'new' keyword, but not initialize
            string[] declareArrayTest2 = new string[4] {"bill", "ted", "excellent", ""}; // Declare with array size, 'new' keyword, AND initialize
            string[] declareArrayTest3 = new string[] {"bob", "john", "test"}; // Declare without array size, 'new' keyword, AND initialize
            string[] declareArrayTest4 = { "sam", "phil", "jacob" }; // Declare without array size, without 'new' keyword, AND initialize
            string[] declareArrayTest5; // Declare without anything!
            declareArrayTest5 = new string[] { "test1", "test2", "test3" };
        }
    }
}
