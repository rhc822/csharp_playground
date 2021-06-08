using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    public class Class_DerivedChild : Class_BaseParent
    {
        public string _modelName;
        public Class_DerivedChild(string modelName)
        {
            _modelName = modelName;
        }

    }
}
