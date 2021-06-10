using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    public class Class_DerivedChild : Class_BaseParent
    {
        public string _modelName;
        public Class_DerivedChild(string modelName, string make)
        {
            _modelName = modelName;
            base.Make = make;
        }

        public override void honk()
        {
            Console.WriteLine("Vree Vree!");
        }

    }
}
