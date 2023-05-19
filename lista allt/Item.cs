using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_allt
{
    class Item
    {
        public string Name { get; set; } // Egenskap för att lagra objektets ägare

        public Item(string name) // Konstruktör för att initialisera det ägda objektet
        {
            Name = name;
        }
    }
}
