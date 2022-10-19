using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public class FireArm : IFireArm
    {
        public Caliber Caliber { get; set; }
        public int MagasinCapacity { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public float Weight { get; set; }

        public float fire()
        {
            return (((float)Power * ((float)Caliber) / (float)MagasinCapacity) + Weight)*1000f;
        }
    }
}
