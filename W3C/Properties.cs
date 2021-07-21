using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class Properties
    {
        private string name;
        public string Name
        {
            // Long-form way of writing out properties
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; } // Short-form way of writing out properties
        public string Workplace { get; } = "Acadia"; // 'get' only
        private string mood;
        public string Mood 
            {
            set { mood = value; } // Must do long-form way for 'set' only
            }
        public void PropertiesWIP()
        {

        }



    }
}
