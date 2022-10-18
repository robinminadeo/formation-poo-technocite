using Abstraction;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lapin = new Rabbit("Roger", "rabbit", 4);
            var chien = new Dog("pluto", "chien", 4);
            var chat = new Cat("Felix", "chat", 4);

            Console.WriteLine(chat.GetFullName());
            Console.WriteLine(chien.GetFullName());
            Console.WriteLine(lapin.GetFullName());

            chat.Sleep();
            chien.Sleep();
            lapin.Sleep();

            chat.Hunt();
            chien.Hunt();
            lapin.Hunt();
            Console.WriteLine();
            Animal chienAnimal = new Dog("pluto", "chien", 4);
            Animal chatAnimal = new Cat("Felix", "chat", 4);
            Animal lapinAnimal = new Rabbit("Roger", "rabbit", 4);

            chatAnimal.Sleep();
            chienAnimal.Sleep();
            lapinAnimal.Sleep();

            chatAnimal.Hunt();
            chienAnimal.Hunt();
            lapinAnimal.Hunt();
        }
    }
}