using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class UserInput
    {
        public void UserInputProgram()
        {
            /****************************************************

            Playing around with User Input

            ****************************************************/

            Console.WriteLine("Enter a name:");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter a name!");
                name = Console.ReadLine();
            }

            Console.WriteLine();

            bool parseSuccess = false;
            int age;

            do
            {
                Console.WriteLine("Enter your desired age (must be a number):");
                var ageString = Console.ReadLine();
                parseSuccess = int.TryParse(ageString, out age);
            } while (!parseSuccess);

            Console.WriteLine($"Hello, I'm {name}!");
            Console.WriteLine($"My age is {age}");

            // FUTURE BUILD-OUT
            // Logic that determines if the input is a string, int, and so on. And how to handle the input, including mixed inputs
            // E.g. The input could be "123", "A Street", "123 A Street", or "123 A St."
            // how to parse the input? How to separate, if at all? If any alpha character or word, then the whole thing is considered a string?
            // So it goes back to purpose of program.
            // I could initiate type validation to ensure only a certain type is entered.

        }
    }
}
