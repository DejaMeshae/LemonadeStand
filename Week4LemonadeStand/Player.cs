using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Player
    {
        //member variable (has a)
        public double Wallet;
        Inventory inventory;
        

        //constructor (build this)
        public Player()
        {
            Wallet = 20.00; //player starts off with $20 what does the f mean like 20f
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