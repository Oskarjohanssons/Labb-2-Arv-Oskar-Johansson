﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv_Oskar_Johansson
{
    public class Dachshund : Dog
    {
        public Dachshund(int newAge, string newName, string newSpecies, string newFavoritFood, string newRoar)
        {

        }
        public void Dig()
        {
            Console.WriteLine($"Meatballs");
        }
    }
}
