using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class InterfaceImplementationClass : IAnimalSound_InterfaceTwo
    {
        public string _animalSound;

        public InterfaceImplementationClass(string animalSound)
        {
            _animalSound = animalSound;
        }
        public void animalSound()
        {
            Console.WriteLine($"The animal says {_animalSound}");
        }
    }
}
