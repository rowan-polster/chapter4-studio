using System;
using System.Collections.Generic;
using System.Text;

namespace chapter4_studio
{
    class Menu
    {
        public List<MenuItem> MenuItems { get; set; } //menu consists of several menuItems
        public DateTime LastUpdated { get; set; } //applies to the entire menu, not just each individual item
        public string RestaurantName { get; set; }

        public Menu(List<MenuItem> menuItems, DateTime lastUpdated, string restaurantName)
        {
            MenuItems = menuItems;
            LastUpdated = lastUpdated;
            RestaurantName = restaurantName;
        }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public object AddItem(object menuItem)
        {
            MenuItems.Add((MenuItem)menuItem);
            return MenuItems;
        }

        public object RemoveItem(object menuItem)
        {
            MenuItems.Remove((MenuItem)menuItem);
            return MenuItems;
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Welcome to Fancy Burger Place! Try our new seasonal items added for Autumn.\nMenu Updated: {this.LastUpdated = DateTime.Today}\n\n");

            Console.WriteLine("\n\n**********  APPETIZERS  **********\n\n");

            foreach (MenuItem item in MenuItems)
            {
                if(item.Category == "Appetizer")
                {
                    item.PrintItem();
                }
            }

            Console.WriteLine("\n\n**********  OUR SIGNATURE BURGERS  **********\n\n");

            foreach (MenuItem item in MenuItems)
            {
                if(item.Category == "Main Course")
                {
                    item.PrintItem();
                }
            }

            Console.WriteLine("\n\n**********  DESSERTS  **********\n\n");

            foreach(MenuItem item in MenuItems)
            {
                if (item.Category == "Dessert")
                {
                    item.PrintItem();
                }
            }
        }
    }
}
