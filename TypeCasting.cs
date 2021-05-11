using System;


namespace c_sharp_playground
{
    public class TypeCasting
    {

       public void TypeCastingExamples()
        {

            /****************************************************

            Playing around with Type Casting

            ****************************************************/

            // Implicit casting
            Console.WriteLine("TYPE CASTING!");
            int tcInt = 10;
            Console.WriteLine("Value of variable 'tcInt': " + tcInt + "\n" + "Type of variable 'tcInt': " + tcInt.GetType().Name);
            float tcFloat = tcInt;
            Console.WriteLine("Value of variable 'tcFloat': " + tcFloat + "\n" + "Type of variable 'tcFloat': " + tcFloat.GetType().Name);
            double tcDouble = tcFloat;
            Console.WriteLine("Value of variable 'tcDouble': " + tcDouble + "\n" + "Type of variable 'tcDouble': " + tcDouble.GetType().Name);

            Console.WriteLine(); // empty space in console

            // Explicit casting (two ways):
            int ecInt = 1;
            float ecFloat = 0.0000F;
            double ecDouble = 1.234567890123D;
            Console.WriteLine("Value of variable 'ecInt': " + ecInt + "\n" + "Type of variable 'ecInt': " + ecInt.GetType().Name);
            Console.WriteLine("Value of variable 'ecFloat': " + ecFloat + "\n" + "Type of variable 'ecFloat': " + ecFloat.GetType().Name);
            Console.WriteLine("Value of variable 'ecDouble': " + ecDouble + "\n" + "Type of variable 'ecDouble': " + ecDouble.GetType().Name);

            Console.WriteLine(); // empty space in console

            // 1) using parentheses ([desired type]) before variable
            Console.WriteLine("Explicit type casting using parentheses!");
            int ecFloatToInt = (int)ecFloat; // seems to always round down
            Console.WriteLine("Value of variable 'ecFloatToInt': " + ecFloatToInt + "\n" + "Type of variable 'ecFloatToInt': " + ecFloatToInt.GetType().Name);
            float ecDoubleToFloat = (float)ecDouble; // truncates to floating point precision
            Console.WriteLine("Value of variable 'ecDoubleToFloat': " + ecDoubleToFloat + "\n" + "Type of variable 'ecDoubleToFloat': " + ecDoubleToFloat.GetType().Name);

            Console.WriteLine(); // empty space in console

            // 2) Type conversion methods: ToString, ToInt32 (int), ToInt64 (long), ToDouble, ToBoolean
            Console.WriteLine("Explicit type casting using ToString type conversion method");
            Console.WriteLine("Value of variable 'ecInt': " + Convert.ToString(ecInt) + "\n" + "Type of variable 'ecInt': " + Convert.ToString(ecInt).GetType().Name);
            Console.WriteLine("Value of variable 'ecFloat': " + Convert.ToString(ecFloat) + "\n" + "Type of variable 'ecFloat': " + Convert.ToString(ecFloat).GetType().Name);
            Console.WriteLine("Value of variable 'ecDouble': " + Convert.ToString(ecDouble) + "\n" + "Type of variable 'ecDouble': " + Convert.ToString(ecDouble).GetType().Name);

            Console.WriteLine(); // empty space in console

            Console.WriteLine("Explicit type casting using ToInt32 type conversion method");
            Console.WriteLine("Value of variable 'ecInt': " + Convert.ToInt32(ecInt) + "\n" + "Type of variable 'ecInt': " + Convert.ToInt32(ecInt).GetType().Name);
            Console.WriteLine("Value of variable 'ecFloat': " + Convert.ToInt32(ecFloat) + "\n" + "Type of variable 'ecFloat': " + Convert.ToInt32(ecFloat).GetType().Name);
            Console.WriteLine("Value of variable 'ecDouble': " + Convert.ToInt32(ecDouble) + "\n" + "Type of variable 'ecDouble': " + Convert.ToInt32(ecDouble).GetType().Name);

            Console.WriteLine(); // empty space in console

            Console.WriteLine("Explicit type casting using ToDouble type conversion method");
            Console.WriteLine("Value of variable 'ecInt': " + Convert.ToDouble(ecInt) + "\n" + "Type of variable 'ecInt': " + Convert.ToDouble(ecInt).GetType().Name);
            Console.WriteLine("Value of variable 'ecFloat': " + Convert.ToDouble(ecFloat) + "\n" + "Type of variable 'ecFloat': " + Convert.ToDouble(ecFloat).GetType().Name); // This "added" precision numbers to the end of the number, not just a bunch of zeroes
            Console.WriteLine("Value of variable 'ecDouble': " + Convert.ToDouble(ecDouble) + "\n" + "Type of variable 'ecDouble': " + Convert.ToDouble(ecDouble).GetType().Name);

            Console.WriteLine(); // empty space in console

            // Any non-zero is converted to boolean 'true'
            Console.WriteLine("Explicit type casting using ToBoolean type conversion method");
            Console.WriteLine("Value of variable 'ecInt': " + Convert.ToBoolean(ecInt) + "\n" + "Type of variable 'ecInt': " + Convert.ToBoolean(ecInt).GetType().Name);
            Console.WriteLine("Value of variable 'ecFloat': " + Convert.ToBoolean(ecFloat) + "\n" + "Type of variable 'ecFloat': " + Convert.ToBoolean(ecFloat).GetType().Name);
            Console.WriteLine("Value of variable 'ecDouble': " + Convert.ToBoolean(ecDouble) + "\n" + "Type of variable 'ecDouble': " + Convert.ToBoolean(ecDouble).GetType().Name);

            Console.WriteLine(); // empty space in console
            
        }
    }
}
