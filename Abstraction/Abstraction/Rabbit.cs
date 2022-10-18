using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rabbit : Animal
    {
        public Rabbit(string name, string specie, int legNumber) : base(name, specie, legNumber)
        {
        }

        public override void Hunt()
        {
            Console.WriteLine($"{Name} uses its powerful legs to pounce on its prey");
        }
    }
}
