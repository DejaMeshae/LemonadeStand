using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LemonadeStand
{
    class Program //DONE Clean up
    {
        static void Main(string[] args)
        {   //call all the classes
            Game game = new Game();
            Random rnd = new Random();
            Day day = new Day(rnd);
            Customer customer = new Customer();
            Store store = new Store();
            Inventory inventory = new Inventory();
            Player player = new Player();
            Weather weather = new Weather(rnd);
            Recipee recipee = new Recipee();
            store.RunGame(inventory, player, store, weather, day, recipee, customer); //run ALL the methods
            //game.StartGame()      
        }
    }
}
