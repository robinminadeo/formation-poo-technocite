using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Dog : Animal
    {
        public Dog(string name, string specie, int legNumber) : base(name, specie, legNumber)
        {
        }

        public override void Hunt()
        {
            Console.WriteLine($"{Name} hunts with its pack to find some food");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleeps with pack in a grote");
        }
    }
}
