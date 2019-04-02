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
        Weather weather; //I think I will need something from the weather class here


        //constructor (build this)
        public Day()
        {
            Random rnd = new Random();
            whatDayItIs = 0; //to start the day off at 0. 

            //Customer Customer; //this class will have the methods that display weather then connect to the customer willingness to buy or not
            weather = new Weather(); //I think I will need something from the weather class here
        }
        

        //member method (can do)
        public void DisplayTheDay()
        {
            //for (whatDayItIs = 0; whatDayItIs < 8; whatDayItIs++) //figure out how to only display day 1 then loop and go to day 2 not day 1 day 2 all at once
            
            // Add one to the day each go around
            whatDayItIs++;
            Console.WriteLine("You are on day:       " + whatDayItIs);
        }

    }
}

//working day loop but figure out how to end it at day 7
//member method (can do) 
//        public void DisplayTheDay()
//        {
//            // Add one to the day each go around
//            whatDayItIs++;
//            // Display the result.
//            Console.WriteLine("You are on day:       " + whatDayItIs);
//        }