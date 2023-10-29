using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Ape : Animals
    {
        public string Dancing { get; set; }
        public Ape(int newAge, string newName, string newColor, string newFavoritFood, double newWeight, string dancing)
            : base(newAge, newName, newColor, newFavoritFood, newWeight)
        {
            Dancing = dancing;
        }
        public void Climbing()
        {
            Console.WriteLine($"{Name} is climbing trees");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying Oihaaa Oihaaa");
        }
    }
}
