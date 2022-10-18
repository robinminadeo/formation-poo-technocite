using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamily
{
    public class Animal : Membre<Animal>
    {
        public AnimalType Type { get; set; }
    }
}
