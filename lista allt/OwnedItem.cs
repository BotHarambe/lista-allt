using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_allt
{
    class OwnedItem : Item
    {
        public Owner Owner { get; set; } //Egenskap för att lagra objektets ägare

        public OwnedItem(string name, Owner owner) : base(name) //Konstruktör för att initialisera det ägda objektet
        {
            Owner = owner;
        }
    }
}
