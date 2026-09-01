using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles
{
    public class Cat : Animal, ISkills, IAnimalPlaycs

    {
      
        public void AboutCat()
        {
            Console.WriteLine ("About cat: ");
            SetAnimalColor ("White");
            SetAnimalAge (2);
            Eat ("Fish");
        }
        public void AnimalRun()
        {
            Console.WriteLine("Animal Skill: Run");
        }

        public void AnimalPlay()
        {
            Console.WriteLine("The cat is playing.");
        }
    }
}

