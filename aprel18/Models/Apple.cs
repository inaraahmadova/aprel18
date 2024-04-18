using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal class Apple:Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }

        public Apple(int vitaA,int vitaB,decimal price,string sort):base(price,sort)
        {
            VitaminA = vitaA;
            VitaminB = vitaB;
        }

        public override void Taste()
        {
            Console.WriteLine("Tastes like apple");
        }
    }
}
