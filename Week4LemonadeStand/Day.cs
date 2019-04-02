using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Day
    {
        //member variable (has this)
        int whatDayItIs;

        //constructor (build this)
        public Day()
        {
            Random rnd = new Random();
            whatDayItIs = 0; //to start the day off at 0. 

            //Customer Customer; //this class will have the methods that display weather then connect to the customer willingness to buy or not
            //Weather Weather;

        }

        //member method (can do)
        public void DisplayTheDay()
        {
            // Add one to the day each go around
            whatDayItIs++;
            // Display the result.
            Console.WriteLine("You are on day:       " + whatDayItIs);
        }
    }
}