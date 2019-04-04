﻿using System;
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
        public Recipee recipee;
     

        //contructor (build this)
        public Inventory()
        {
            iceonhand = 0;
            cupsofsugaronhand = 0;
            papercupsonhand = 0;
            lemonsonhand = 0;

            recipee = new Recipee();
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


        public bool HaveEnoughSuppliesToSell()//check and make sure they have enough stuff to sell lemonade 
        {
            recipee = new Recipee();

            if (papercupsonhand > 0 && lemonsonhand >= recipee.LemonsUsedForRecipe & cupsofsugaronhand >= recipee.CupsOfSugarUsedForRecipe && iceonhand >= recipee.IceUsedForRecipe)
            {
                return true;
            }
            return false;
        }









    }
}
