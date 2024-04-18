﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal abstract class Animal
    {
        public string Breed { get; set; }
        public abstract void MakeSound();

        public abstract void EatFood(Food food);
        protected Animal(string breed)
        {
            Breed = breed;
        }
    }
}
