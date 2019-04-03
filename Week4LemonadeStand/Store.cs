using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Store
    {
        //member variable (has a)
        double priceof25papercups = .80;
        double priceof20cupsofsugar = 1.50;
        double priceof30lemons = 2.00;
        double priceof250icecubes = 2.50;
        double cost;
        int howmany; //how many/much of the product the player buys
        double costForThirty;
        Inventory inventory;
        Day day;//move to game class
        Weather weather;
        Player player;

        //constructor
        List<string> differentStuffToBuy = new List<string>{ "30 Lemons for .80", "20 Cups Of Sugar for 1.50", "100 Ice Cubes for .90", "45 Paper Cups for 1.00 \n\n" }; //create list of products in the store

        public Store()
        {
            day = new Day();
            weather = new Weather();
            player = new Player();
            inventory = new Inventory();

        }




        //member method (can do)
        //to test all of the methods will delete later...maybe
        //public void RunGame()
        //{
        //    day.DisplayTheDay();       //this is day 1 
        //    weather.WeatherPicker();   //forecast for today
        //    PurchaseMoreToRestockInventory(); //welcome to store
        //    then the next method to sell the lemonade 
        //    Console.ReadLine();
        //}

        public void PurchaseMoreToRestockInventory()
        {
            day.DisplayTheDay();
            weather.WeatherPicker(); 
            Console.WriteLine("Welcome to Deja's Market you can buy: ");
            differentStuffToBuy.ForEach(Console.WriteLine);//display list
            Console.WriteLine("What would you like to purchase? [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, \n hit [b] to show your inventory hit [D] when you are done shopping. \n\n");
            Console.ReadLine();//just as a place holder to get it to show
           

            string purchase = Console.ReadLine().ToLower();
            switch (purchase)
            {
                case "l":
                    BuyLemons(); // will have to put the entire method here
                    break;
                case "s":
                    BuySugar();
                    break;
                case "i":
                    BuyIce();
                    break;
                case "c":
                    BuyPaperCups();
                    break;
                case "b":
                    inventory.ShowInventory();
                    break;
                case "d":
                    //done with shopping ready to sell some shit
                    break;
                default:
                    Console.WriteLine("\n Nope lets try that again! Try [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, hit [B] to show your inventory hit [D] when you are done shopping \n\n");
                    PurchaseMoreToRestockInventory();
                    break; // i think break goes here idk. when i remove it theres a red swigly under default. after further research im sure break goes here
            }
        }
                public void BuyIce()
                {
                    throw new System.NotImplementedException();
                }

                public void BuyLemons()
                {
            //double priceof30lemons = 2.00;
                    howmany = 30; //represent 30 lemons
                    // cost minus wallet 
                    inventory.iceonhand += howmany;   //when player buys lemons, their inventory of lemmons goes up by 30
                    player.Wallet -= priceof30lemons; // player wallet minus priceof30lemons  
                    // return BuyLemons(); // I feel like it should return something but idk what

                }

        public void BuyPaperCups()
                {
                    throw new System.NotImplementedException();
                }

                public void BuySugar()
                {
                    throw new System.NotImplementedException();
                }
    }
}


