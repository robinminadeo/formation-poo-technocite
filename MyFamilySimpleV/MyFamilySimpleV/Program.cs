using System;

namespace MyFamilySimpleV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Fabienne = new Human() { Age = 52, Name = "Fabienne", LastName = "Fabienne II", Sexe = Sexe.FEMALE, Parents = new List<Membre> { } };
            var Frederic = new Human() { Age = 49, Name = "Frederic", LastName = "Frederic II", Sexe = Sexe.MALE, Parents = new List<Membre> { } };
            var Robin = new Human() { Age = 26, Name = "Robin", LastName = "Minadeo", Sexe = Sexe.MALE, Parents = new List<Membre> { } };

            Robin.Parents.Add(Frederic);
            Robin.Parents.Add(Fabienne);

            var Sam = new Animal() { Name = "Sam", Age = 3, Sexe = Sexe.FEMALE, Parents = new List<Membre> { }, Type = AnimalType.CANID };
            var Scampy = new Animal() { Name = "Scampy", Age = 1, Sexe = Sexe.MALE, Parents = new List<Membre> { }, Type = AnimalType.CANID };
            var Twix = new Animal() { Name = "Twix", Age = 1, Sexe = Sexe.MALE, Parents = new List<Membre> { }, Type = AnimalType.CANID };
            Twix.Parents.Add(Sam);
            Console.WriteLine((Robin.GetFather() as Human).LastName);
            Console.WriteLine((Robin.GetMother() as Human).LastName);

            Console.WriteLine((Twix.GetMother() as Animal).Type);
        }
    }
}