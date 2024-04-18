using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal class Lion : Animal
    {
        public Lion(string breed):base(breed)
        {
            
        }
        public bool IsPrideLeader {  get; set; }
        public override void EatFood(Food food)
        {
           if (food is Meat)
            {
                Console.WriteLine("Ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("yalnish qida");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("sounds as lion");
        }
    }
}
