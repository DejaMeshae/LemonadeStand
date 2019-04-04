using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Recipee
    {
        //member variable
        public int iceUsedForRecipe;
        public int cupsOfSugarUsedForRecipe;
        public int paperCupsUsedForRecipe;
        public int lemonsUsedForRecipe;

        //constructor
        public Recipee()
        {
            iceUsedForRecipe = 0;
            cupsOfSugarUsedForRecipe = 0;
            paperCupsUsedForRecipe = 0;
            lemonsUsedForRecipe = 0;
        }

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


        //member method
    }
}
