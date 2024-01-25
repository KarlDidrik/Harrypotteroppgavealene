using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrypotteroppgavealene
{
    internal class HarryPotter
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string House { get; set; }
        private string Item { get; set; }

        public HarryPotter(string name, int age, string house, string item)
        {
            Name = name;
            Age = age;
            House = house;
            Item = item;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Hello {Name}, welcome to Hogwart. I see on your registration that you are {Age} years old and brought {Item} as your item. The hat on your head says that you are going to {House}. Cool!");
        }
    }
}
