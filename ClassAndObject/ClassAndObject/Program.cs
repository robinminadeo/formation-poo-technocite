using ClassAndObject;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Pluto", "Canidé", 4, "Border collie");
            Console.WriteLine( Animal.NbAnimals);
            /*Console.WriteLine(Animal.NbAnimals);
            var lapin = new Animal("Roger", "Rabbit", 4);
            var chien = new Animal("Pluto", "Dog", 4);
            var chat = new Animal("Berlioz", "Cat", 4);
            Console.WriteLine(Animal.NbAnimals);
            lapin.Hunt();
            chien.GetFullName();
            chat.Hunt();
            InitOtherAnimals();
            Console.WriteLine($"After InitOtherAnimals {Animal.NbAnimals}");*/
        }

        private static void InitOtherAnimals()
        {
            /*Console.WriteLine($"At start of InitOtherAnimals {Animal.NbAnimals}");
            var lapin2 = new Animal("Roger2", "Rabbit", 4);
            var chien2 = new Animal("Pluto2", "Dog", 4);
            var chat2 = new Animal("Berlioz2", "Cat", 4);
            Console.WriteLine($"At End of InitOtherAnimals {Animal.NbAnimals}");*/
        }
    }
}