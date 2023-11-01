using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdhfbv.Classes
{
    public class Human : Animal
    {
        public string Color { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Kind { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Люди всеядны");
        }
    }
}
