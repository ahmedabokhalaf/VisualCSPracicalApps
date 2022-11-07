using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zoo zoo = new Zoo();
            //try
            //{
            //    zoo.Add(new Lion());
            //    zoo.Add(new Sparrow());
            //    zoo.Add(new Elephant());
            //    zoo.Add(new Pigeon());
            //}
            //catch (AnimalAgeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Animals animaldied = new Elephant(7, true);
            //zoo.Add(animaldied);
            //Console.WriteLine("Birds");
            //foreach (Animals bird in zoo.Birds)
            //{
            //    Console.WriteLine(bird.ToString());
            //}

            //Console.WriteLine("===================================\nMammals");
            //foreach (Animals mammal in zoo.Mammals)
            //{
            //    Console.WriteLine(mammal.ToString());
            //}

            //Console.WriteLine("=====================================\nAll Animals");
            //foreach (Animals animal in zoo.Animals)
            //{
            //    Console.WriteLine(animal.ToString());
            //}

            //=============================================================
            PhoneBook phoneBook = new PhoneBook();
            phoneBook[123] = "Ali";
            phoneBook["Hosam"] = 456;
            string phone = phoneBook[456];

            phoneBook["Khalaf"] = 789;

            Console.WriteLine(phone);

            //animaldied.Notify += zoo.Remove;
            //animaldied.Die();
            //foreach (Animals animal in zoo.Animals)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
        }
    }
}
