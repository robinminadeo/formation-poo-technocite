using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public class ColdSteel : IColdSteel
    {
        public Matter Matter { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public float Weight { get; set; }

        public float cut()
        {
            return ((float)Power * Weight / Size) * (float)Matter;
        }
    }
}
