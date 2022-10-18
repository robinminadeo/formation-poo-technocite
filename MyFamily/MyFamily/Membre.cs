using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamily
{
    public abstract class Membre<T> : IMembre<T>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Sexe Sexe { get; set; }

        public List<T>? Parents { get; set; }


        public T GetFather()
        {
            try
            {
                return (T)GetParentBySexe(Sexe.MALE);
            }
            catch
            {
                Console.WriteLine($"{Name} n'a pas de père");
                return default;
            }
        }

        public T GetMother()
        {
            try
            {
                return GetParentBySexe(Sexe.FEMALE);
            }
            catch
            {
                Console.WriteLine($"{Name} n'a pas de mère");
                return default;
            }
        }

        private T GetParentBySexe(Sexe sexe)
        {
            if (Parents == null || Parents.Count == 0)
            {
                throw new Exception("No Parents");
                return default;
            }

                var parent = Parents.FirstOrDefault(x => {
                    var prop = x.GetType().GetProperty("Sexe");
                    if(prop != null)
                    {
                        var sexeProp = (Sexe) prop.GetValue(x);
                        return sexeProp != null ? sexe == sexeProp : false;
                    }
                    return false;
                });
                if (parent == null)
                {
                    throw new Exception("No Parents");
                return default;
            }
            return parent;
        }
    }
}
