using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Rottweiler : Dog
    {
        public string Runing { get; set; }
        public Rottweiler(int newAge, string newName, string newColor, string newFavoritFood, double newWeight, string runing, string breed)
            : base(newAge, newName, newColor, newFavoritFood, newWeight, breed)
        {
            Runing = runing;
        }
        public void TrowFrisbee()
        {
            Console.WriteLine($"{Name} is loving to play trow frisbee");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying WOFF WOFF");
        }
    }
}
