using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamilySimpleV
{
    public interface IMembre
    {
        public Membre GetFather();
        public Membre GetMother();
    }
}
