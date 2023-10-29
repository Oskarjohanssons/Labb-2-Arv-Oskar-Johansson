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
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }
        public double Weight { get; set; }
        public Animals(int newAge, string newName, string newColor, string newFavoritFood, double newWeight)
        {
            Age = newAge;
            Name = newName;
            Color = newColor;
            FavoriteFood = newFavoritFood;
            Weight = newWeight;


        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"The animal is saying something");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavoriteFood} yummy!!");
        }
        public void Sleep() 
        {         
            Console.WriteLine($"{Name} is now sleeping shhhhh!!!");
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} years old");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Favorit food: {FavoriteFood}");
        }


    }

}
