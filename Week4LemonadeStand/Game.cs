﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Game
    {
        //member variable (has a)
        UserInterface UserInterface; //i think i will use this in the future
        Player Player;
        Day day;  
        Store store;


        //constructor (build this)
        public Game()
        {
            Player = new Player(); 
            day = new Day();
            store = new Store();
        }



        //member method (can do)



    }
}