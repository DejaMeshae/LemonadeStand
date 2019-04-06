using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Recipee //DONE go back and clean up
    {
        //member variable
        //i think I need to set these to private
        public int iceUsedForRecipe;
        public int cupsOfSugarUsedForRecipe;
        public int paperCupsUsedForRecipe;
        public int lemonsUsedForRecipe;
        public float pricePerCup;

        //constructor
        //public Recipee() dont think i need this since i have a get set
        //{
        //    iceUsedForRecipe = 0;
        //    cupsOfSugarUsedForRecipe = 0;
        //    paperCupsUsedForRecipe = 0;
        //    lemonsUsedForRecipe = 0;
        //}

        public int LemonsUsedForRecipe
        {
            get
            {
                return lemonsUsedForRecipe;
            }
            set
            {
                lemonsUsedForRecipe = value;
            }
        }

        public int CupsOfSugarUsedForRecipe
        {
            get
            {
                return cupsOfSugarUsedForRecipe;
            }
            set
            {
                cupsOfSugarUsedForRecipe = value;
            }
        }

        public int IceUsedForRecipe
        {
            get
            {
                return iceUsedForRecipe;
            }
            set
            {
                iceUsedForRecipe = value;
            }
        }

        public float PricePerCup
        {
            get
            {
                return pricePerCup;
            }
            set
            {
                pricePerCup = value;
            }
        }


        //member method
        internal void PricePerCupToSell()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade?");
            if (float.TryParse(Console.ReadLine(), out pricePerCup))
            {
                //pricePerCup = Math.Round(pricePerCup, 2); //player cant put 343.4643645
                Console.WriteLine("You have set the price to $" + pricePerCup + " a cup \n");
                Console.ReadLine();  //delete later, test line
                //maybe a  a max of $1cup?
            }
            else
            {
                Console.WriteLine("\n Nope lets try that again! Try numbers ");
                PricePerCupToSell();
            }
        }

        internal void IceCubesPerCup(Inventory inventory, Player player)//may need to delete whats in the parameters is i dont display inventory
        {
            Console.WriteLine("Lets make lemonade!");
            player.inventory.ShowProductsToMakeLemonade(player); //displays inventory
            Console.WriteLine("How many ice cubes would you like in each cup?");
            if (Int32.TryParse(Console.ReadLine(), out iceUsedForRecipe))
            {
                Console.WriteLine("Okay " + iceUsedForRecipe + " ice cubes per cup \n");
            }
            else
            {
                Console.WriteLine("\n Nope lets try that again! Try numbers");
                IceCubesPerCup(inventory, player);
            }
        }

        internal void CupsOfSugarPerPitcher(Inventory inventory, Player player)
        {
            //player.inventory.ShowProductsToMakeLemonade(player); //displays inventory again but dont reflect new inventory after used ice
            //maybe have inventory display again with new inventory levels
            Console.WriteLine("How many cups of sugar would you like per pitcher?");
            if (Int32.TryParse(Console.ReadLine(), out cupsOfSugarUsedForRecipe))
            {
                Console.WriteLine("Okay " + cupsOfSugarUsedForRecipe + " cups of sugar per pitcher \n");
            }
            else
            {
                Console.WriteLine("\n Nope lets try that again! Try numbers");
                CupsOfSugarPerPitcher(inventory, player);
            }
        }

        internal void LemonsUsedPerPitcher(Inventory inventory, Player player)
        {
            //player.inventory.ShowProductsToMakeLemonade(player); //displays inventory again but dont reflect new inventory after used ice
            //maybe have inventory display again with new inventory levels
            //player.inventory.ShowProductsToMakeLemonade(player); //displays inventory
            Console.WriteLine("How many lemons would you like per pitcher?");
            if (Int32.TryParse(Console.ReadLine(), out lemonsUsedForRecipe))
            {
                Console.WriteLine("Okay " + lemonsUsedForRecipe + " lemon per pitcher \n");
            }
            else
            {
                Console.WriteLine("\n Nope lets try that again! Try numbers");
                LemonsUsedPerPitcher(inventory, player);
            }
        }
        //end here
    }
}
