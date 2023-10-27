using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Animals
    {
        public int Age;
        public string Name;
        public string Species;
        public string FavoriteFood;
        public string Roar;
        public Animals(int newAge, string newName, string newSpecies, string newFavoritFood, string newRoar)
        {
            Age = 0;
            Name = "No Name";
            Species = "No Species added";
            FavoriteFood = "No favorite food added";
            Roar = "No roar was implemented";

        }
        public void Makesound()
        {
            Console.WriteLine($"The {Species} is saying {Roar}");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavoriteFood} yummy!!");
        }
        public void Sleep() 
        {         
            Console.WriteLine($"{Name} is sleeping.");
        }


    }

}
