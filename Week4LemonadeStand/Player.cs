using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Player
    {
        //member variable (has a)
        public double Money;
        Inventory inventory;
        

        //constructor (build this)
        public Player()
        {
            Money = 20.00; //player starts off with $20
            inventory = new Inventory();
        }


        //member method (can do)
        public void HowMuchMoneyRemains()
        {
            throw new System.NotImplementedException();
        }

        public void HowMuchMoneyGainedOrLost()
        {
            throw new System.NotImplementedException();
        }
    }
}