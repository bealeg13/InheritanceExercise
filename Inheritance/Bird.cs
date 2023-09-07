using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool CanTalk { get; set; }
        public int Wings { get; set; } = 2;
        public string Habitat { get; set; } = "desert";


        public void ShowBirdQualities()
        {
            Console.WriteLine($"Ostriches are able to fly: {CanFly}");
            Console.WriteLine($"Ostriches are able to talk: {CanTalk}");
            Console.WriteLine($"Ostriches have {Wings} wings but are unable to fly.");
            Console.WriteLine($"Ostriches primarily are found in the {Habitat}");
        }
}   }
