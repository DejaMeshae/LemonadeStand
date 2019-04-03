using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public static class UserInterface //cant instanciate classes in static 
     {
        //member variable 
        //DELETE 

        //public Day day; 
        //public Weather weather;
        //public Customer customer; 
        //public Inventory inventory;
        //public Store store;
        //public Game game;

        //constructor(build this) //instanciate ALL the classes yay!
        //DELETE

        //public UserInterface()
        //{
        //    inventory = new Inventory();
        //    day = new Day();
        //    store = new Store();
        //    customer = new Customer();
        //    game = new Game();
        //    weather = new Weather();
        //}


        //member method (can do)
        //contains all of the ConsoleWritelines
        public static void SayThis()
        {
            //all of the console writes
        }

        public static void ExitGameMessage() //
        {
            Console.WriteLine("You have no money.");
        }
    }
}