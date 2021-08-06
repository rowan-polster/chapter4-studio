using System;
using System.Collections.Generic;
using System.Text;

namespace chapter4_studio
{
    class Restaurant
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();

            //Main Courses

            MenuItem frenchPig = new MenuItem("French Pig", 8.99, "Caramalized onions, melted brie, golden fig jam, and applewood-smoked pork belly on a brioche roll. Choice of patty: 100% Angus beef, Impossible patty, black bean patty.", "Main Course", false);
            MenuItem oktoberfest = new MenuItem("Oktoberfest", 8.99, "Beer-battered onion straws, applewood-smoked bacon, honey mustard, and beer cheese sauce on a pretzel bun. Choice of patty: 100% Angus beef, Impossible patty, black bean patty.", "Main Course", true);
            MenuItem mushroom = new MenuItem("Garlic Mushroom", 8.99, "Crimini, Shiitake, and minced Porcini mushrooms drizzled with garlic-rosemary butter, topped with smoked swiss cheese on a split-top bun. Choice of patty: 100% Angus beef, Impossible patty, black bean patty.", "Main Course", true);
            MenuItem classic = new MenuItem("Classic", 8.99, "Beefsteak tomatoes, red onions, house-made pickles, romaine lettuce, and smoked cheddar cheese with our secret sauce on a sesame bun. Choice of patty: 100% Angus beef, Impossible patty, black bean patty.", "Main Course", false);
            MenuItem nastyPatty = new MenuItem("Nasty Patty", 0.99, "Why is this on the menu?!", "Main Course", true);

            menu.AddItem(frenchPig);
            menu.AddItem(oktoberfest);
            menu.AddItem(mushroom);
            menu.AddItem(classic);
            menu.AddItem(nastyPatty);



            //Appetizers

            MenuItem fries = new MenuItem("Truffle Fries", 7.99, "Hand-cut gold potatoes fried in duck fat, tossed in black garlic and flaked sea salt. Comes with a side of black truffle aioli.", "Appetizer", false);
            MenuItem seasonalSalad = new MenuItem("Harvest Salad", 8.99, "Baby spinach and arugala tossed in apple cider vinegrette, with fig halves, Harley Farms goat cheese, applewood smoked bacon and roasted sunflower seeds.", "Appetizer", true);
            MenuItem pretzels = new MenuItem("Pretzel Bites", 5.99, "Salted pretzel bites with a side of beer cheese sauce", "Appetizer", true);
            MenuItem wings = new MenuItem("Habanero Cider Wings", 10.99, "Deep-fried chicken wings tossed in our speciality glaze of Angry Orchard hard apple cider, habenero peppers, and local honey. Sweet heat!", "Appetizer", true);
            MenuItem onionRings = new MenuItem("Beer-Battered Onion Rings", 7.99, "Thick-cut Vidalia onions beer-battered and deep fried in duck fat, served with a trio of specialty sauces", "Appetizer", false);


            menu.AddItem(fries);
            menu.AddItem(seasonalSalad);
            menu.AddItem(pretzels);
            menu.AddItem(wings);
            menu.AddItem(onionRings);


            //Desserts

            MenuItem beignets = new MenuItem("Boozy Beignets", 7.99, "Apple cider beignets with a shot of caramel bourbon on the side.", "Dessert", true);
            MenuItem pie = new MenuItem("Sweet Potato Pie", 5.99, "Creamy sweet potato pie with a graham cracker crust.", "Dessert", true);
            MenuItem sorbet = new MenuItem("Persimmon Sorbet", 3.99, "Tart persimmon sorbet with a blood orange cream wafer.", "Dessert", true);
            MenuItem appleCake = new MenuItem("Apple Cake", 5.99, "A dense, thick slice of apple cake with black walnuts and brown butter bourbon glaze", "Dessert", true);
            MenuItem chocolateCake = new MenuItem("Chocolate Truffle Cake", 5.99, "A rich dark chocolate cake layered with chocolate ganache and dark chocolate buttercream, topped with chocolate truffles and curls. Comes with a side of blood orange sauce.", "Dessert", true);

            menu.AddItem(beignets);
            menu.AddItem(pie);
            menu.AddItem(sorbet);
            menu.AddItem(appleCake);
            menu.AddItem(chocolateCake);

            //menu.RemoveItem(nastyPatty);


            menu.PrintMenu();
            
        }
    }
}
