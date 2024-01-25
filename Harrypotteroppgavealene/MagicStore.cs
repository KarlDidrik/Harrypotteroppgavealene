using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrypotteroppgavealene
{
    internal class MagicStore
    {
        List<string> Wand
        = new List<string>(){"Troll wand", "Pheonix wand", "unicord wand"};
        List<string> Animal
        = new List<string>(){"Rat", "Owl", "Cat"};


        public void Store()
        {
            Console.WriteLine("Welcome to my Magic store! What would you like to buy today? I have Wands (1) and pets (2)");
             var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"Here is the wand i have in stock!");
                foreach (var Wands in Wand)
                {
                    Console.WriteLine($"{Wands}");
                }
            }
            else
            {
                foreach (var Animals in Animal)
                {
                    Console.WriteLine($"{Animals}");
                }
            }
        }







    }

}
