using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamily
{
    public class Human : Membre<Human>
    {
        public string LastName { get; set; }
    }
}
