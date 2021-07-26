using System;
using System.Collections.Generic;
using System.Text;

namespace chapter4_studio
{
    public class Menu
    {
        private DateTime lastUpdated {get; set;}
        public class MenuItems
        {
            private string Name { get; set; }
            private double Price { get; set; }
            private string Description { get; set; }
            private List<string> Category { get; set; }
            private bool IsNew { get; set; }

            public MenuItems(string name, double price, string description, List<string> category, bool isNew)
            {
                this.Name = name;
                this.Price = price;
                this.Description = description;
                this.Category = category;
                this.IsNew = isNew;
            }
        }
    }
}
