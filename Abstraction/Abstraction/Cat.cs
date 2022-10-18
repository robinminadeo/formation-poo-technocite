using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Cat : Animal
    {
        public Cat(string name, string specie, int legNumber) : base(name, specie, legNumber)
        {
        }

        public override void Hunt()
        {
            Console.WriteLine($"{Name} is too lazy to hunt");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} sleep all day long");
        }
    }
}
