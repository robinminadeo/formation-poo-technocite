using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamily
{
    public interface IMembre<T>
    {
        public T GetFather();
        public T GetMother();
    }
}
