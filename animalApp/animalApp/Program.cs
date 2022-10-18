using animalApp;

using Newtonsoft.Json;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        private static List<Reptile> reptiles = new List<Reptile>() { new Serpent() { Espece ="Pantherophis", Grandeur= 1, Nb_pattes = 0 , SexeEnum= Sexe.FEMALE}, new Serpent() { Espece = "Lampropeltis", Grandeur = 2, Nb_pattes = 0, SexeEnum = Sexe.FEMALE } };

        public static string Reptiles
        {
            get => JsonConvert.SerializeObject(reptiles);
            set
            {
                var repts = JsonConvert.DeserializeObject<List<Reptile>>(value);
                if (repts != null)
                {
                    reptiles = repts ;
                }
            }
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine(new Archeopterix { Espece = "autruche bizarre", Grandeur = 1, SexeEnum = Sexe.MALE, Nb_pattes = 2, Type = TypeOiseau.TROPICAL }.ToString());
            var type = "{ \"Type\":0,\"Espece\":\"autruche bizarre\",\"Nb_pattes\":2,\"SexeEnum\":1,\"Grandeur\":1}";
            Archeopterix p = JsonSerializer.Deserialize(type, typeof(Archeopterix)) as Archeopterix;*/

            Console.WriteLine(Reptiles);
            Reptiles = "[{\"Espece\":\"Pantherophis\",\"Nb_pattes\":0,\"SexeEnum\":0,\"Grandeur\":2}]";
            Console.WriteLine(Reptiles);

        }
    }
}