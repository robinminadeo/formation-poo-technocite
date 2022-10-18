using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalApp
{
    public class Reptile : IReptile
    {
        public string Espece { get; set; }
        public int Nb_pattes { get; set; }
        public Sexe SexeEnum { get; set; }

        public int Grandeur { get; set; }

        public void attaque()
        {
            throw new NotImplementedException();
        }

        public string cri()
        {
            throw new NotImplementedException();
        }

        public string deplacement()
        {
            throw new NotImplementedException();
        }
    }
}
