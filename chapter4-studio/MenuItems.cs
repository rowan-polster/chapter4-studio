using System;
using System.Collections.Generic;
using System.Text;

namespace chapter4_studio
{
        public class MenuItems
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }  //Maybe a list? This way seems more straightforward?? Categories include Appetizer, Main, and Dessert
            public bool IsNew { get; set; } //if dish was added in the last 60 days, IsNew = true
        }
    }

