﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Inventory inventory = new Inventory();
            Player player = new Player();
            Weather weather = new Weather();
            Day day = new Day();
            store.RunGame(inventory, player, store, weather, day); //run ALL the methods

        }
    }
}
