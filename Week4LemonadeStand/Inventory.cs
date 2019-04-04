using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Inventory
    {
        //member variable (has a)
        public int iceonhand;
        public int cupsofsugaronhand;
        public int papercupsonhand;
        public int lemonsonhand;
     

        //contructor (build this)
        public Inventory()
        {
            iceonhand = 0;
            cupsofsugaronhand = 0;
            papercupsonhand = 0;
            lemonsonhand = 0;
        }

        //member method (can do)
        public void ShowInventory(Store store, Player player)
        {
            Console.WriteLine("You now have $" + player.Wallet);
            Console.WriteLine("You have: " + lemonsonhand + " lemons");
            Console.WriteLine("You have " + cupsofsugaronhand + " cups of sugar");
            Console.WriteLine("You have " + iceonhand + " ice cubes");
            Console.WriteLine("You have " + papercupsonhand + " paper cups \n");
            store.PurchaseMoreToRestockInventory(store, player); //calls the method from store class through userinterface
        }












    }
}