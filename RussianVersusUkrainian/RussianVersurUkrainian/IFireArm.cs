using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public interface IFireArm : IArm
    {
        public Caliber Caliber { get; set; }
        public int MagasinCapacity { get; set; }

        public float fire();
    }
}
