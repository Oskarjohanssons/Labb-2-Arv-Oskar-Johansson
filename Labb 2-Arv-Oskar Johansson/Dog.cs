using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Dog : Animals
    {
        public string Breed { get; set; }
        public Dog(int newAge, string newName, string newColor, string newFavoritFood, double newWeight, string breed)
            : base(newAge, newName, newColor, newFavoritFood, newWeight)
        { 
            Breed = breed;
        }  
        public void Walk()
        {
            Console.WriteLine($"{Name} likes to go on a Walk");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying Woof Woof");
        }
        public void breed()
        {
            Console.WriteLine($"He/she is a {Breed}");
        }
    }
}
