using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public bool HasTeeth { get; set; } = true;
        public string Habitat { get; set; }
        public int Eyes { get; set; } = 2;

        public void ShowReptileQualities()
        {
            Console.WriteLine($"Alligator have sharp teeth: {HasTeeth}");
            Console.WriteLine($"Alligators have rough scales: {HasScales}");
            Console.WriteLine($"Alligators live in the {Habitat} and have {Eyes} eyes to see");

        }
    }
}