namespace MyFamilySimpleV
{
    public class Membre : IMembre
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public Sexe Sexe { get; set; }

        public List<Membre>? Parents { get; set; }


        public Membre GetFather()
        {
            try
            {
                return GetParentBySexe(Sexe.MALE);
            }
            catch
            {
                Console.WriteLine($"{Name} n'a pas de père");
                return null;
            }
        }

        public Membre GetMother()
        {
            try
            {
                return GetParentBySexe(Sexe.FEMALE);
            }
            catch
            {
                Console.WriteLine($"{Name} n'a pas de mère");
                return null;
            }
        }

        private Membre GetParentBySexe(Sexe sexe)
        {
            if (Parents == null || Parents.Count == 0)
            {
                throw new Exception("No Parents");
                return default;
            }

            var parent = Parents.FirstOrDefault(x => x.Sexe == sexe);
            if (parent == null)
            {
                throw new Exception("No Parents");
                return null;
            }
            return parent;
        }

    }
}