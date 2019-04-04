using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Player
    {
        //private float wallet;
        public Inventory inventory;

        


        //constructor (build this)
        public Player()
        {
            //wallet = 20.00f; //player starts off with $20 what does the f mean like 20f

            inventory = new Inventory();
        }

        private double wallet = 20.00;
        public double Wallet
        {
            get
            {
                return wallet;
            }
            set
            {
                if(value <= 0)
                {
                    wallet = 0;
                }
                else
                {
                    wallet = value;
                }
            }
         }


        //member method (can do)
        public void HowMuchMoneyGainedOrLost()
        {
            throw new System.NotImplementedException();
        }


        public void CheckWalletToMakeSureNotBroke() //instaciate the userinterface class so i can call a method from there
        {
            if (wallet <= 0) //if player have no money left
            {
                UserInterface.ExitGameMessage(); //capital U can just called the method because userinterface is static
                //Environment.Exit(0); //abrutly ends the game not sure if I want this in my game
            }
            else
            {
                return;
            }
        }
    }
}
