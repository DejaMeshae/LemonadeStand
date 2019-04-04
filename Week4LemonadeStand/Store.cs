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
        private float cost; //i think i need this idk
        int howmany; //how many/much of the product the player buys

        //constructor
        List<string> differentStuffToBuy = new List<string>{ "30 Lemons for 2.00", "20 Cups Of Sugar for 1.50", "100 Ice Cubes for .90", "45 Paper Cups for 1.00 \n\n" }; //create list of products in the store

       

        //member method (can do)
        //to test all of the methods will delete later...maybe
        public void RunGame(Inventory inventory, Player player, Store store, Weather weather, Day day)
        {
            day.DisplayTheDay();       //this is day 1 
            weather.WeatherPicker();   //forecast for today
            //weather.TemperturePicker();
            Console.WriteLine("Welcome to Deja's Market you can buy: ");
            differentStuffToBuy.ForEach(Console.WriteLine);//display list
            Console.WriteLine("You have $" + player.Wallet + "\n");
            //day.DisplayTheDay(); //delete all these and below later. this is for testing day method
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
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
           

            string purchase = Console.ReadLine().ToLower();//user can put in upper or lower and it'll auto lower it
            switch (purchase)
            {
                case "l":
                    //BuyLemons(store, player); // all of the buy methods are at the bottom
                    break;
                case "s":
                   // BuySugar(store, player);
                    break;
                case "i":
                    BuyIce(store, player);
                    break;
                case "c":
                    //BuyPaperCups(store, player);
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

            public double WalletMinusCost (Player player, float cost)
                {
                return (player.Wallet -= cost);
                }

            public void BuyIce(Store store, Player player)
                {
                    //100icecubes cost .90;
                    cost = .90f;
                    howmany = 100; //represent 100 ice cubes
                    player.inventory.iceonhand += howmany; //add 100 ice cube to current ice inventory 
                    WalletMinusCost(player, cost); //method above to subtact .90 from player wallet
                    //player.Wallet -= priceof100icecubes; //subtract .90 from player wallet
                    player.CheckWalletToMakeSureNotBroke();
                    player.inventory.ShowInventory(store, player);
                }

            //public void BuyLemons(Store store, Player player)
            //    {
            //        //double priceof30lemons = 2.00;
            //        howmany = 30; //represent 30 lemons           
            //        player.inventory.lemonsonhand += howmany;  //when player buys lemons, their inventory of lemmons goes up by 30
            //        player.Wallet -= priceof30lemons;          // player wallet minus priceof30lemons  
            //        player.CheckWalletToMakeSureNotBroke();
            //        player.inventory.ShowInventory(store, player);
            //    }

            //public void BuyPaperCups(Store store, Player player)
            //    {
            //        //priceof45papercups = 1.00;
            //        howmany = 45;
            //        player.inventory.papercupsonhand += howmany;
            //        player.Wallet -= priceof45papercups;
            //        player.CheckWalletToMakeSureNotBroke();
            //        player.inventory.ShowInventory(store, player);
            //    }

            //public void BuySugar(Store store, Player player)
            //    {
            //        //priceof20cupsofsugar = 1.50;
            //        howmany = 20;
            //        player.inventory.cupsofsugaronhand += howmany;
            //        player.Wallet -= priceof20cupsofsugar;
            //        player.CheckWalletToMakeSureNotBroke();
            //        player.inventory.ShowInventory(store, player);
            //    }
    }
}


