using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_allt
{
    class Program
    {
        static List<OwnedItem> inventory = new List<OwnedItem>(); //  Lista för att stora inventory av owned items
        static void Main(string[] args)
        {
            Owner owner1 = new Owner("Owner 1"); // skapar instans med owener 1
            Owner owner2 = new Owner("Owner 2"); // skapar instans med owener 1

            OwnedItem item1 = new OwnedItem("Item A", owner1); // Skapar en instans av owneditem med namet a och tillhör owner 1
            OwnedItem item2 = new OwnedItem("Item B", owner1); // samma
            OwnedItem item3 = new OwnedItem("Item C", owner2); // Skapar en instans av owneditem med namet c och tillhör owner 2

            inventory.Add(item1); // lägger item1 till inventory list
            inventory.Add(item2);  // samma
            inventory.Add(item3); // samma för dem andara

            PrintInventory(); // skriver ut inverntoy

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Console.ReadLine();
        }
        static void PrintInventory()
        {
            Console.WriteLine("Inventory List:");
            foreach (var item in inventory)
            {
                Console.WriteLine("Item: +" + item.Name); // skriver namnent av itemn
                Console.WriteLine("Owner: +" + item.Owner.Name); // skriver ägaren av itme
                Console.WriteLine();
            }
        }
      
    }

}
