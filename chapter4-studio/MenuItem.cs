using System;
using System.Collections.Generic;
using System.Text;

namespace chapter4_studio
{
    class MenuItem
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public void PrintItem()
        {
            string dish = ($"{this.Name}..................${this.Price.ToString()}\n{this.Description}\n\n");

            if (IsNew)
            {
                Console.WriteLine("(NEW!) " + dish);
            }
            else
            {
                Console.WriteLine(dish);
            }
        }

        public override string ToString()
        {
            return ($"{this.Name}\n${this.Price}\n{this.Description}");
        }
    }
}

