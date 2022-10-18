using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Animal
    {
        public static int NbAnimals = 0;
        public string Name { get; set; }
        public string Specie { get; set; }

         public int LegNumber { get; set; }

        public Animal(string name, string specie, int legNumber)
        {
            Name = name;
            Specie = specie;
            LegNumber = legNumber;
            NbAnimals += 1;
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting");
        }

        public string GetFullName()
            => $"Name: {Name}, Specie : {Specie}";
    }
}
