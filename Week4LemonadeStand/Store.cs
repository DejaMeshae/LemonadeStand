using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Store
    {
        //member variable (has a)
        public int priceof25papercups;
        public int priceofcupsofsugar;
        public int priceoflemons;
        public int priceoficecubes;
        public Inventory inventory;


        //constructor
        public Store()
        {
            inventory = new Inventory();
            double priceof30lemons = 2.00;
            double priceof250icecubes = 2.50;
            double priceof20cupsofsugar = 1.50;
            double priceof25papercups = .80;
        }

              public Game Game;





        ////member method (can do)
        //public void RestockInventory(Player player)
        //{
        //    Console.WriteLine("What would you like to purchase0? [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, or hit [ENTER] to take you back to the Main Menu. \n\n");

        //    string purchase = Console.ReadLine().ToLower();
        //    switch (purchase)
        //    {
        //        case "l":
        //            GetLemons(player);
        //            break;
        //        case "s":
        //            GetSugar(player);
        //            break;
        //        case "i":
        //            GetIce(player);
        //            break;
        //        case "c":
        //            GetCups(player);
        //            break;
        //        case "m":

        //            break;
        //        default:
        //            Console.WriteLine("Sorry! Try [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, or [ENTER] to take you back to the Main Menu.");
        //            Restock(player);
        //            break;
        //    }
        //}
        public void BuyIce()
        {
            throw new System.NotImplementedException();
        }

        public void BuyLemons()
        {
            throw new System.NotImplementedException();
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