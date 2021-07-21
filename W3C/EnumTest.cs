using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    enum EnumTest // enum as it's own class
    {
        low,
        medium,
        high
    }

    public class EnumTestClass
    {
        public enum Dates // enum within a class
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July = 30, // Assign a value and the remainder follow
            August,
            September,
            October,
            November,
            December
        }
    }
}
