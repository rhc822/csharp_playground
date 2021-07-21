using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class Booleans
    {
        bool isHappy = true;
        bool isSad = false;
        int a = 10;
        int b = 9;
        

        public void BooleanActivelyWorkingOn()
        {
            Console.WriteLine($"I am Happy? {isHappy}\nI am sad? {isSad}");
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.WriteLine($" a > b? {a > b}");
            Console.WriteLine($"a = 10? {a == 10}");
            Console.WriteLine(10 >= 15);
        }

        public void BooleanExamples()
        {

        }
    }
}
