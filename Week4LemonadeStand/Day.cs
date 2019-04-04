using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Day
    {
        //member variable (has this)
        Weather weather; //I think I will need something from the weather class here
        Customer customer;

        //constructor (build this)
        public Day()
        {
            //List<int> differentDays = new List<int> { 1, 2, 3, 4, 5, 6, 7 }; //create list of days

            weather = new Weather(); //I think I will need something from the weather class here
            customer = new Customer();
        }


        //member method (can do)
        public void DisplayTheDay()
        {
            //List<int> differentDays = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 }); //create list of days

            //int dIndex = (differentDays.Length);
            for (int whatDayItIs = 1; whatDayItIs < 8; whatDayItIs++) //figure out how to only display day 1 then loop and go to day 2 not day 1 day 2 all at once
            {
                if (whatDayItIs < 8)
                {
                    Console.WriteLine("You are on day:" + whatDayItIs);
                }
                else
                    break;
            }                      
        }
    }
}
