using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalApp
{
    public interface IAnimal
    {
        public string Espece { get; set; }
        public int Nb_pattes { get; set; }
        public Sexe SexeEnum { get; set; }

        public void attaque();
        public string cri();
    }
}
