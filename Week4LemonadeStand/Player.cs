using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Player
    {
        public Recipee recipee;
        public Inventory inventory;
       

        private double wallet = 20.00;
        


        //constructor (build this)
        public Player()
        {
            inventory = new Inventory();
            recipee = new Recipee();
        }

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
        internal void CheckWalletToMakeSureNotBroke(Player player) //instaciate the userinterface class so i can call a method from there
        {
            if (Wallet <= 0) //if player have no money left
            {
                //UserInterface.ExitGameMessage(); //capital U can just called the method because userinterface is static but dont need this
                Console.WriteLine("You do not have any more money to buy more supplies. Let's go make your recipe");
                recipee.IceCubesPerCup(inventory, player);
                //Environment.Exit(0); //abrutly ends the game not sure if I want this in my game
            }
            else
            {
                return;
            }
        }

        public void HowMuchMoneyGainedOrLost()
        {
            throw new System.NotImplementedException();
        }
    }
}
