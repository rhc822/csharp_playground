using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_playground
{
    class InterfaceImplementationClass : IAnimalSound_InterfaceTwo, IAnimalName_InterfaceOne
    {
        public string AnimalName { get; set; }
        public string _animalSound;

        public InterfaceImplementationClass(string animalName, string animalSound)
        {
            _animalSound = animalSound;
            AnimalName = animalName;
        }
        public void animalSound()
        {
            Console.WriteLine($"The {AnimalName} says {_animalSound}");
        }
    }
}
