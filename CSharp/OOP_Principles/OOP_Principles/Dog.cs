using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles
{
    public class Dog : Animal, ISkills, IAnimalPlaycs
    {
        public void AboutDog()
        {
            Console.WriteLine ("About Dog: ");
            SetAnimalColor ("black");
            Eat ("Dentastix");
        }

        public void AnimalRun()
        {
            Console.WriteLine("Animal Skill: Run");
        }

        public void AnimalPlay()
        {
            Console.WriteLine("The dog is playing.");
        }

        private string dogName;
            public string Name
        {
            get
            {
                return dogName;
            }
            set
            {
                dogName = value;
            }
        }
    }
}
