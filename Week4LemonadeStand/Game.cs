using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Game
    {
        //member variable (has a)
        Player Player;
        //List<Day> Days; for method below
        Day day;  
        Store store;


        //constructor (build this)
        public Game()
        {
            Player = new Player(); 
            day = new Day();
            store = new Store();
        }



        //member method (can do) work on this, day method here
        //public void DisplayDay()
        //{
        //    for (int i = 0; i < Days.Count; i++)
        //    {
        //        Days[i].RunDay();
        //    }
        //}


    }
}