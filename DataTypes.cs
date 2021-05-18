using System;


namespace c_sharp_playground
{
    class DataTypes
    {
        public void DataTypeExamples()
        {
            /****************************************************

            Playing around with primitive data types

            ****************************************************/

            // Characters and Strings
            Console.WriteLine("STRINGS AND THINGS!");
            char myChar = 'a'; //  can't use double quotes for char
            string firstName = "Slate"; // string
            Console.WriteLine("first name = " + firstName);
            string lastName = "SlamFish"; // another string
            Console.WriteLine("last name = " + lastName);
            string fullName = firstName + " " + lastName; //combined string
            Console.WriteLine("Full Name = " + fullName);

            Console.WriteLine(); // empty space in console


            // Numbers
            Console.WriteLine("NUMBERS!");
            int number = 123; // integer
            Console.WriteLine("number = " + number);
            int anotherNumber = 456;
            Console.WriteLine("anotherNumber = " + anotherNumber);
            Console.WriteLine(number + anotherNumber); // When concatenating two variables holding integers, the result is addition, unless....
            Console.WriteLine("Combined numbers = " + number + anotherNumber); // you have a string in the mix, then it simply puts them together, unless...
            Console.WriteLine("Combined numbers = " + (number + anotherNumber)); // you put parentheses around the two integers in the expression

            long myLongNum = 1234567890123456789L; // convention to end with an "L"
            Console.WriteLine("Long number: " + myLongNum);

            float myFloat = 1.234567891023456789F;// MUST end with an "F", 
            Console.WriteLine("Floating point number: " + myFloat); // truncates number, precision to six or seven digits

            double myDouble = 1.12345678901234567890123456789012345678901234567890D; // convention to end with a "D"
            Console.WriteLine("Double number: " + myDouble); // truncates number, precision to around 15 digits

            // Turns out, there's a difference between being able to STORE a large number and DISPLAY that number

            // Scientific notation for Float or Double only
            float snFloat = 1.2e8F; // Displays in console all digits
            float snFloatAbbr = 1.2e9F; // Displays in console in scientific notation format at this point and above
            Console.WriteLine("Scientific Notation for Float number unabbreviated: " + snFloat);
            Console.WriteLine("Scientific Notation for Float number (abbreviated): " + snFloatAbbr);

            double snDouble = 1.2e16D; // Displays in console all digits
            double snDoubleAbbr = 1.2e17D;  // Displays in console in scientific notation format at this point and above
            Console.WriteLine("Scientific Notation for Double number: " + snDouble);
            Console.WriteLine("Scientific Notation for Double number: " + snDoubleAbbr);

            Console.WriteLine(); // empty space in console


            // Declare many variables (of the same type)
            Console.WriteLine("DECLARE MANY VARIABLES (OF THE SAME TYPE)!");
            int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.WriteLine(a + b + c + d + e + f);

            Console.WriteLine(); // empty space in console


            // Contants
            Console.WriteLine("CONSTANTS!");
            const double constantNumber = 3.14;
            Console.WriteLine("constantNumber = " + constantNumber);

            Console.WriteLine(); // empty space in console


            // Delcare variable but not assigned
            Console.WriteLine("DECLARE VARIABLE BUT NOT ASSIGNED!");
            string something;
            // variable now assigned
            something = "Something is assigned";
            Console.WriteLine("The first 'something' = " + something);
            // variable now re-assigned
            something = "Something ELSE is assigned. It's another string.";
            Console.WriteLine("The second, or re-assigned 'something' = " + something);

            Console.WriteLine(); // empty space in console


            // Booleans
            Console.WriteLine("BOOLEANS!");
            bool myBoolean = true;
            Console.WriteLine("boolean currently = " + myBoolean);
            myBoolean = false;
            Console.WriteLine("boolean currently = " + myBoolean);

            Console.WriteLine(); // empty space in console
        }

    }
}
