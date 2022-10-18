using System;

namespace MyFamily // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Fabienne = new Human() { Age = 52, Name = "Fabienne", LastName = "X", Sexe = Sexe.FEMALE, Parents = new List<Human> { } };
            var Frederic = new Human() { Age = 49, Name = "Frederic", LastName = "X", Sexe = Sexe.MALE, Parents = new List<Human> { } };
            var Robin = new Human() { Age = 26, Name = "Robin", LastName = "Minadeo", Sexe = Sexe.MALE, Parents = new List<Human> { } };

            Robin.Parents.Add(Frederic);
            Robin.Parents.Add(Fabienne);

            var Sam = new Animal() { Name = "Sam", Age = 3, Sexe = Sexe.FEMALE, Parents = new List<Animal> { } };
            var Scampy = new Animal() { Name = "Scampy", Age = 1, Sexe= Sexe.MALE, Parents = new List<Animal> { } };
            var Twix = new Animal() { Name = "Twix", Age = 1, Sexe = Sexe.MALE, Parents = new List<Animal> { } };
            Twix.Parents.Add(Sam);
            Console.WriteLine(Robin.GetFather().Name);
            Console.WriteLine(Robin.GetMother().Name);

            Console.WriteLine(Twix.GetMother().Name);
        }
    }
}