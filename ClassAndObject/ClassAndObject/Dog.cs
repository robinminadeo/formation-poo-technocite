using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public Dog( string name, string specie, int legNumber, string race) : base(name, specie, legNumber)
        {
            Race = race;
        }
    }
}
