using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public interface IColdSteel : IArm
    {
        public float Size { get; set; }
        public Matter Matter { get; set; }

        public float cut();
    }
}
