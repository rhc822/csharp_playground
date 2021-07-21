using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace c_sharp_playground
{
    public class LINQ
    {
        
        public static void LinqExample()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

            foreach (int i in scoreQuery)
            {

                Console.Write(i + " ");

            }

        } 
    }
}
