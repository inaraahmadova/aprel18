using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC { get; set; }
        public Orange(int vitaC, decimal price, string sort) : base(price, sort)
        {
            VitaminC = vitaC;
        }

        public override void Taste()
        {
            Console.WriteLine("Tastes like orange");
        }
    }
}
