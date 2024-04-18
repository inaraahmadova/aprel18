using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public Pineapple(int vitaE, int vitaD, decimal price, string sort) : base(price, sort)
        {
            VitaminE = vitaE;
            VitaminD = vitaD;
        }
        public override void Taste()
        {
            Console.WriteLine("Tastes like pineapple");
        }
    }
}
