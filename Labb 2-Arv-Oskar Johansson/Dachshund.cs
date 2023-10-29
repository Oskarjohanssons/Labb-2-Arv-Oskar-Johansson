using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Dachshund : Dog
    {
        public string Playing { get; set; }
        public Dachshund(int newAge, string newName, string newColor, string newFavoritFood, double newWeight, string playing,string breed)
            : base(newAge, newName, newColor, newFavoritFood, newWeight,breed)
        {
            Playing = playing;
        }
        public void Dig()
        {
            Console.WriteLine($"{Name} is loving to dig after treasures.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying woff woff");
        }
    }
}
