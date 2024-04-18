using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel18.Models
{
    internal class Cow : Animal
    {
        public Cow(string breed):base(breed)
        {
            
        }
        public override void EatFood(Food food)
        {
            if (food is Grass)
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
            Console.WriteLine("sounds as cow");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("milk produced");
        }
    }
}
