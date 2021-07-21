using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class Strings
    {

        /****************************************************

        Playing around with Strings

        ****************************************************/

        public string _hello;
        public string _howAreYou;

        public Strings(string hello, string howAreYou)
        {
            _hello = hello;
            _howAreYou = howAreYou;
        }

        public void StringsActivelyWorkingOn()
        {

        }

        public void StringsExamples()
        {
            Console.WriteLine(_hello);
            Console.WriteLine($"The length of the string above is {_hello.Length}");
            Console.WriteLine(_howAreYou);
            Console.WriteLine($"The length of the string above is {_howAreYou.Length}");

            //Some methods
            Console.WriteLine($"ToUpper method: {_hello.ToUpper()}");
            Console.WriteLine($"ToLower method: {_hello.ToLower()}");

            // Concatenation
            string combinedGreeting1 = "This concatenation uses a plus sign: " + _hello + _howAreYou; // Concatenated with + sign
            Console.WriteLine(combinedGreeting1);
            string combinedGreeting2 = string.Concat(_hello, _howAreYou); // Concatenated by using 'Concat' method  
            Console.WriteLine($"This concatenation uses the 'Concat' method: {combinedGreeting2}");

            // Access characters in a string using the bracket notation
            Console.WriteLine($"The first letter is {_hello[0]} {_hello[1]}");
            Console.WriteLine(_hello.IndexOf("!")); //case sensitive and unicode only, interesting

            //Substring method
            int indexPosition = _hello.IndexOf("t");
            Console.WriteLine($"The second word is: {_hello.Substring(indexPosition)}");

            // Escape characters for strings
            Console.WriteLine($"These escape \"double quotes\" are good."); // Double quote escape 
            Console.WriteLine($"These escape \'single quotes\' are also good."); // Single quote escape 
            Console.WriteLine($"These escape \\backslashes\\ are gooder still."); // Backslash escape
            Console.WriteLine($"Each\nword\nis\non\na\nnew\nline"); // new line escape
            Console.WriteLine($"Each\tword\tis\ttabbed"); // tab escape
            Console.WriteLine($"Each\bword\bis\bbackspaced"); // backspace escape

        }
    }
}
