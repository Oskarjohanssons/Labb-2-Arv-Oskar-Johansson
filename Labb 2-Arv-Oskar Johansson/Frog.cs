using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Frog : Animals
    {
        public string Jump { get; set; }
        public Frog(int newAge, string newName, string newColor, string newFavoritFood, double newWeight, string jump)
            : base(newAge, newName, newColor, newFavoritFood, newWeight)
        {
             Jump=jump;
        }
        public void Eating()
        {
            Console.WriteLine($"{Name} likes to eat flyes");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying Rabbit Rabbit");
        }
    }
}
