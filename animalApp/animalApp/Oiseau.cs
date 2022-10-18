using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalApp
{
    public class Oiseau : IOiseau
    {
        public string Espece { get; set; }
        public int Nb_pattes { get; set; }
        public Sexe SexeEnum { get; set; }

        public TypeOiseau Type { get; set; }

        public string chasse()
        {
            throw new NotImplementedException();
        }

        public void attaque()
        {
            throw new NotImplementedException();
        }

        public string cri()
        {
            throw new NotImplementedException();
        }
    }
}
