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
        public Inventory inventory;


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




        //just testing
        public void CheckMoneyToMakeSureNotBroke() //instaciate the userinterface class so i can call a method from there
        {
            if (Wallet <= 0) //if player have no money left
            {
                UserInterface.ExitGameMessage(); //capital U can just called the method because userinterface is static
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }



    }
}
