using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Store //done clean up
    {
        //member variable (has a)
        double priceof45papercups = 1.00;
        double priceof20cupsofsugar = 1.50;
        double priceof30lemons = 2.00;
        double priceof100icecubes = .60;
        //private float cost; //i think i need this idk
        int howmany; //how many/much of the product the player buys

        //constructor
        public List<string> differentStuffToBuy = new List<string>{ "30 Lemons for $2.00", "20 Cups Of Sugar for $1.50", "100 Ice Cubes for $.60", "45 Paper Cups for $1.00 \n\n" }; //create list of products in the store

       

        //member method (can do)
        //to test all of the methods will delete later...maybe
        public void RunGame(Inventory inventory, Player player, Store store, Weather weather, Day day, Recipee recipee, Customer customer)
        {
            day.DisplayTheDay();       //this is day 1 
            weather.WeatherPicker();   //forecast for today
            
            
            Console.WriteLine("Welcome to Deja's Market you can buy: ");
            differentStuffToBuy.ForEach(Console.WriteLine);//display list
            Console.WriteLine("You have $" + player.Wallet + "\n");
            //day.DisplayTheDay(); //delete all these and below later. this is for testing day method to make sure itll show the correct day
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            //day.DisplayTheDay();
            PurchaseMoreToRestockInventory(store, player, recipee, inventory); //welcome to store
            recipee.CupsOfSugarPerPitcher(inventory,player);
            recipee.LemonsUsedPerPitcher(inventory, player);
            recipee.PricePerCupToSell();//player set the price per cup
            //then the next method to sell the lemonade
            //Console.ReadLine(); //delete dont think i need this line
        }

        public void PurchaseMoreToRestockInventory(Store store, Player player, Recipee recipee, Inventory inventory)
        {
            Console.WriteLine("What would you like to purchase? [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups. \n hit [P] to show the prices, hit [D] when you are done shopping. \n\n");
           
            string purchase = Console.ReadLine().ToLower();//user can put in upper or lower and it'll auto lower it
            switch (purchase)
            {
                case "l":
                    BuyLemons(store, player, inventory); // all of the buy methods are at the bottom
                    break;
                case "s":
                    BuySugar(store, player, inventory);
                    break;
                case "i":
                    BuyIce(store, player,inventory);
                    break;
                case "c":
                    BuyPaperCups(store, player, inventory);
                    break;
                case "p":
                    differentStuffToBuy.ForEach(Console.WriteLine);//display list
                    PurchaseMoreToRestockInventory(store, player, recipee, inventory);
                    break;
                case "d":
                    recipee.IceCubesPerCup(inventory,player);                 
                    break;
                default:
                    Console.WriteLine("\n Nope lets try that again! Try [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, hit [B] to show your inventory hit [D] when you are done shopping \n\n");
                    PurchaseMoreToRestockInventory(store, player, recipee, inventory);
                    break; 
            }
        }

            //public double WalletMinusCost(Player player, float cost) i think i need this not sure yet
            //    {
            //    return (player.Wallet -= cost);
            //    }

             public void BuyIce(Store store, Player player, Inventory inventory)
                {
                    //100icecubes cost .60;
                    //cost = .60f;
                    howmany = 100; //represent 100 ice cubes
                    player.inventory.iceonhand += howmany; //add 100 ice cube to current ice inventory 
                   //WalletMinusCost(player, cost); //method above to subtact .90 from player wallet
                    player.Wallet -= priceof100icecubes;
                    player.CheckWalletToMakeSureNotBroke();
                    player.inventory.ShowInventory(store, player, inventory);
                }

             public void BuyLemons(Store store, Player player, Inventory inventory)
                {
                    //double priceof30lemons = 2.00;
                    howmany = 30; //represent 30 lemons           
                    player.inventory.lemonsonhand += howmany;  //when player buys lemons, their inventory of lemmons goes up by 30
                    player.Wallet -= priceof30lemons;          // player wallet minus priceof30lemons  
                    player.CheckWalletToMakeSureNotBroke();
                    player.inventory.ShowInventory(store, player,inventory);
                }

            public void BuyPaperCups(Store store, Player player, Inventory inventory)
                {
                    //priceof45papercups = 1.00;
                    howmany = 45;
                    player.inventory.papercupsonhand += howmany;
                    player.Wallet -= priceof45papercups;
                    player.CheckWalletToMakeSureNotBroke();
                    player.inventory.ShowInventory(store, player, inventory);
                }

            public void BuySugar(Store store, Player player, Inventory inventory)
                {
                    //priceof20cupsofsugar = 1.50;
                    howmany = 20;
                    player.inventory.cupsofsugaronhand += howmany;
                    player.Wallet -= priceof20cupsofsugar;
                    player.CheckWalletToMakeSureNotBroke();
                    player.inventory.ShowInventory(store, player,inventory);
                }
    }
}
