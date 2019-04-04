using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Recipee
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
                Console.WriteLine("You have set the price to " + pricePerCup + " a cup");
            }
            else
            {
                Console.WriteLine("\n Nope lets try that again! Try numbers ");
                PricePerCupToSell();
            }
        }
    }
}
