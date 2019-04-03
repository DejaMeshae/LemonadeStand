using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Store
    {
        //member variable (has a)
        double priceof45papercups = 1.00;
        double priceof20cupsofsugar = 1.50;
        double priceof30lemons = 2.00;
        double priceof100icecubes = .90;
        double cost; //i think i need this idk
        int howmany; //how many/much of the product the player buys

        //constructor
        List<string> differentStuffToBuy = new List<string>{ "30 Lemons for 2.00", "20 Cups Of Sugar for 1.50", "100 Ice Cubes for .90", "45 Paper Cups for 1.00 \n\n" }; //create list of products in the store

       

        //member method (can do)
        //to test all of the methods will delete later...maybe
        public void RunGame(Inventory inventory, Player player, Store store, Weather weather, Day day)
        {
            day.DisplayTheDay();       //this is day 1 
            weather.WeatherPicker();   //forecast for today
            Console.WriteLine("Welcome to Deja's Market you can buy: ");
            differentStuffToBuy.ForEach(Console.WriteLine);//display list
            PurchaseMoreToRestockInventory(store, player); //welcome to store
            //then the next method to sell the lemonade
            //Console.ReadLine(); //dont think i need this line
        }

        public void PurchaseMoreToRestockInventory(Store store, Player player)
        {
            //day.DisplayTheDay();
            //weather.WeatherPicker(); 
            //Console.WriteLine("Welcome to Deja's Market you can buy: ");
            //differentStuffToBuy.ForEach(Console.WriteLine);//display list
            Console.WriteLine("What would you like to purchase? [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups. \n hit [B] to show your inventory, hit [D] when you are done shopping. \n\n");
            //Console.ReadLine(); //dont need this line, just as a place holder to get it to show
           

            string purchase = Console.ReadLine().ToLower();
            switch (purchase)
            {
                case "l":
                    BuyLemons(store, player); // will have to put the entire method here
                    break;
                case "s":
                    BuySugar(store, player);
                    break;
                case "i":
                    BuyIce(store, player);
                    break;
                case "c":
                    BuyPaperCups(store, player);
                    break;
                case "b":
                    player.inventory.ShowInventory(store, player);
                    break;
                case "d":
                    //done with shopping ready to sell some lemonade
                    break;
                default:
                    Console.WriteLine("\n Nope lets try that again! Try [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, hit [B] to show your inventory hit [D] when you are done shopping \n\n");
                    PurchaseMoreToRestockInventory(store, player);
                    break; // i think break goes here idk. when i remove it theres a red swigly under default. after further research im sure break goes here
            }
        }
            public void BuyIce(Store store, Player player)
            {
                //priceof100icecubes = .90;
                howmany = 100; //represent 100 ice cubes
                player.inventory.iceonhand += howmany; //add 100 ice cube to current ice inventory 
                player.Wallet -= priceof100icecubes; //subtract .90 from player wallet
                player.inventory.ShowInventory(store, player);
            }

        public void BuyLemons(Store store, Player player)
            {
            //double priceof30lemons = 2.00;
            howmany = 30; //represent 30 lemons           
            player.inventory.lemonsonhand += howmany;   //when player buys lemons, their inventory of lemmons goes up by 30
            player.Wallet -= priceof30lemons; // player wallet minus priceof30lemons  
            player.inventory.ShowInventory(store, player);
            }

        public void BuyPaperCups(Store store, Player player)
            {
                //priceof45papercups = 1.00;
                howmany = 45;
                player.inventory.papercupsonhand += howmany;
                player.Wallet -= priceof45papercups;
                player.inventory.ShowInventory(store, player);
            }

            public void BuySugar(Store store, Player player)
            {
                //priceof20cupsofsugar = 1.50;
                howmany = 20;
                player.inventory.cupsofsugaronhand += howmany;
                player.Wallet -= priceof20cupsofsugar;
                player.inventory.ShowInventory(store, player);
            }
    }
}


