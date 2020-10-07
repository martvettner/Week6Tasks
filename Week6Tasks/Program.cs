using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };

            //Provide the following output -->
            //{random superhero} will fight {random Supervillain} with a {random weapon}

            Random rnd = new Random();
            int randomsuperHeroes = rnd.Next(1, superHeroes.Length);
            int randomsuperVillains = rnd.Next(1, superVillains.Length);
            int randomweapons = rnd.Next(1, weapon.Length);



            Console.WriteLine($"{superHeroes[randomsuperHeroes]} will fight {superVillains[randomsuperVillains]} with a {weapon[randomweapons]}");




        }
    }
}
