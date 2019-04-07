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
        public int removeCupsOfSugar;
        public int removeIceCubes;
        public int removeLemons;
        public Recipee recipee;


        //contructor (build this)
        public Inventory()
        {
            recipee = new Recipee();
        }

        //member method (can do)
        public void ShowInventory(Store store, Player player, Inventory inventory)
        {
            Console.WriteLine("You now have $" + player.Wallet);
            Console.WriteLine("You have: " + lemonsonhand + " lemons");
            Console.WriteLine("You have " + cupsofsugaronhand + " cups of sugar");
            Console.WriteLine("You have " + iceonhand + " ice cubes");
            Console.WriteLine("You have " + papercupsonhand + " paper cups \n");
            store.PurchaseMoreToRestockInventory(store, player, recipee, inventory); //calls the method from store class through userinterface
        }

        public bool HaveEnoughSuppliesToSell()//check and make sure they have enough stuff to sell lemonade 
        {
            recipee = new Recipee();

            if (papercupsonhand > 0 && lemonsonhand >= recipee.LemonsUsedForRecipe & cupsofsugaronhand >= recipee.CupsOfSugarUsedForRecipe && iceonhand >= recipee.IceUsedForRecipe)
            {
                return true;
            }
            Console.WriteLine("You don't have enough stock to sell");//change to an if else and else cww sold out
            return false;
        }

        //may not need this delete later
        public void ShowProductsToMakeLemonade(Player player) 
        {
            Console.WriteLine("You have: " + lemonsonhand + " lemons");
            Console.WriteLine("You have " + cupsofsugaronhand + " cups of sugar");
            Console.WriteLine("You have " + iceonhand + " ice cubes");
            Console.WriteLine("You have " + player.inventory.papercupsonhand + " paper cups \n");
        }

        public int CupsOfSugarAfterMadeRecipe(Recipee recipee, Inventory inventory, Player player)
        {
            try
            {
                removeCupsOfSugar = player.inventory.cupsofsugaronhand -= recipee.CupsOfSugarUsedForRecipe;
                return removeCupsOfSugar;
            }
            catch (Exception)
            {
                Console.WriteLine("You do not have that amount in your inventory, try again! \n");
                recipee.CupsOfSugarPerPitcher(inventory, player);
                throw;
            }
        }

        public int IceCubesOnHandAfterMadeRecipe(Recipee recipee, Inventory inventory, Player player)
        {
            try
            {
                removeIceCubes = player.inventory.iceonhand -= recipee.iceUsedForRecipe;
                return removeIceCubes;
            }
            catch (Exception)
            {
                Console.WriteLine("You do not have that amount in your inventory, try again! \n");
                recipee.IceCubesPerCup(inventory, player);
                throw;
            }
        }

        public int LemonsOnHandAfterMadeRecipe(Recipee recipee, Inventory inventory, Player player)
        {
            try
            {
                removeLemons = player.inventory.lemonsonhand -= recipee.lemonsUsedForRecipe;
                return removeLemons;
            }
            catch (Exception)
            {
                Console.WriteLine("You do not have that amount in your inventory, try again! \n");
                recipee.LemonsUsedPerPitcher(inventory, player);
                throw;
            }
        }

    }
}
