using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public interface IArm
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public float Weight { get; set; }
    }
}
