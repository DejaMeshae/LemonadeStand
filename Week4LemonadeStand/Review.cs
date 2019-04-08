using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LemonadeStand
{
    class Review 
    {
        //member variable
        public float totalCupsSold;
        public float iceCubesUsedToday;
        public float lemonsUsedToday;
        public float cupsOfSugarUsedToday;
        public float moneyMadeToday;


        //constructor 
        public float TotalCupsSold
        {
            get
            {
                return totalCupsSold;
            }
            set
            {
                totalCupsSold = value;
            }
        }

        public float MoneyMadeToday
        {
            get
            {
                return moneyMadeToday;
            }
            set
            {
                moneyMadeToday = value;
            }
        }

        public float LemonsUsedToday
        {
            get
            {
                return lemonsUsedToday;
            }
            set
            {
                lemonsUsedToday = value;
            }
        }

        public float CupsOfSugarUsedToday
        {
            get
            {
                return cupsOfSugarUsedToday;
            }
            set
            {
                cupsOfSugarUsedToday = value;
            }
        }

        public float IceCubesUsedToday 
        {
            get
            {
                return iceCubesUsedToday;
            }
            set
            {
                iceCubesUsedToday = value;
            }
        }

        //member method
       
        public void UpdateCupsUsed(Day day, Inventory inventory) //minus from invnetory after a cup is sold
        {
            inventory.papercupsonhand -= 1;
        }

        public void CalculateSugarUsed(Day day, Player player, Recipee recipee) //Minus from inventory
        {
            cupsOfSugarUsedToday = totalCupsSold * recipee.CupsOfSugarUsedForRecipe;
            player.inventory.cupsofsugaronhand = player.inventory.cupsofsugaronhand - recipee.CupsOfSugarUsedForRecipe;
        }

        public void CalculateLemonsUsed(Day day, Player player, Recipee recipee)
        {
            lemonsUsedToday = totalCupsSold * recipee.lemonsUsedForRecipe;
            player.inventory.lemonsonhand = player.inventory.lemonsonhand - recipee.lemonsUsedForRecipe;
        }
        public void CalculateIceUsed(Day day, Player player, Recipee recipee)
        {
            iceCubesUsedToday = totalCupsSold * recipee.iceUsedForRecipe;
            player.inventory.iceonhand = player.inventory.iceonhand - recipee.iceUsedForRecipe;
        }

    }
}
