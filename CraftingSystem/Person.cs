using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Person
    {
        public string PersonName = "Anonymous";
        public double Currency = 10.5;
        public List<Item> Inventory = new List<Item>();
        public Person() { }
        public Person(string name)
        {
            PersonName = name;
            //test data temporary
            //Item itemOne = new Item();
            Inventory.Add(new Item()
            {
                ItemName = "Water",
                ItemAmount = 6,
                ItemValue = 2.0
            });
            Inventory.Add(new Item()
            {
                ItemName = "Sugar",
                ItemAmount = 1,
                ItemValue = .25
            });
            Inventory.Add(new Item()
            {
                ItemName = "Flour",
                ItemAmount = 2,
                ItemValue = .5
            });
        }
        public string ShowInventory()
        {
            string output = $"Inventory for {PersonName}:\n";
            foreach (Item item in Inventory)
            {
                output += $"   * {item.ItemAmount} of {item.ItemName} ({item.ItemValue.ToString("c")} each){Environment.NewLine}";
            }

            return output;

        }
        public string About()
        {
            //interpolation
            string output = $"{PersonName} {Currency.ToString("c")}";
            //concatenation
            //string output = PersonName + " " + Currency.ToString("c");
            //composite formatting
            //string output = "{0} {1.ToString(\"c\")}", PersonName, Currency;
            return output;
        }
        public void ChangeName(string name)
        {
            PersonName = name;
        }
    }
}