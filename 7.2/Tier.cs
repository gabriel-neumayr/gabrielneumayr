using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{

    abstract class Tier : IComparable
    {
        protected string name="";
        protected float gewicht;
        protected string birthdate="";
        
        protected string animalKind;

        protected Tier(string name, string animaleKind) {
        this.animalKind = animalKind;
        this.name = name;
        }

        public int CompareTo(object obj)
        {
            Tier other = obj as Tier;
            return animalKind.CompareTo(other.animalKind);
        }

        public string GetName()
        {
            return name;
        }
        public string GetAnimalKind()
        {
            return animalKind;
        }
        public virtual void Steckbrief(float gewicht, string birthdate)
        {
            Console.WriteLine();
            this.gewicht = gewicht;
            this.birthdate = birthdate;
            Console.WriteLine("Steckbrief von " + name);
            Console.WriteLine("Gewicht: " + gewicht);
            Console.WriteLine("Birthdate: " + birthdate);
        }
    }
}
