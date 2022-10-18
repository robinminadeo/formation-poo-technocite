using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Animal
    {
        public static int NbAnimals = 0;
        public string Name { get; set; }
        public string Specie { get; set; }

        public int LegNumber { get; set; }

        protected Animal(string name, string specie, int legNumber)
        {
            Name = name;
            Specie = specie;
            LegNumber = legNumber;
            NbAnimals += 1;
        }

        public abstract void Hunt();
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        public string GetFullName()
            => $"Name: {Name}, Specie : {Specie}";
    }
}
