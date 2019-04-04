using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Player
    {
        
        public Inventory inventory;

        


        //constructor (build this)
        public Player()
        {
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
        internal void CheckWalletToMakeSureNotBroke() //instaciate the userinterface class so i can call a method from there
        {
            if (Wallet <= 0) //if player have no money left
            {
                UserInterface.ExitGameMessage(); //capital U can just called the method because userinterface is static
                Console.WriteLine("You ran out of money, the game is now over. Press any key");
                Console.ReadLine();
                //want it to go to selling the leomonde with whatever inventory they have, reciepe class will have a method if they have enought invnetory then sell,no the game will keep going. well end at day 7
                // second idea want to display the player profit/lost then environment exit
                Environment.Exit(0); //abrutly ends the game not sure if I want this in my game
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
