using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class Class_DerivedChild2 : Class_BaseParent
    {
        public string _modelName;


        public Class_DerivedChild2(string modelName, string make)
        {
            _modelName = modelName;
            base.Make = make;
        }

        public override void honk()
        {
            Console.WriteLine("Beep Beep!");
        }
    }

    class Class_DerivedChild3 : Class_BaseParent
    {
        public string _modelName;

        public Class_DerivedChild3(string modelName, string make)
        {
            _modelName = modelName;
            base.Make = make;
        }

        public override void honk()
        {
            Console.WriteLine("WEEE WEE!");
        }
    }
}
