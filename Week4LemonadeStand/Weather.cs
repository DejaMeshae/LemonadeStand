using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Weather
    {
        //member variable


        //constructor (build this)
        Day Day;
        Random rnd = new Random();
        string[] differentWeatherTypes = {"Sunny", "Rainy", "Cloudy"};


        ////member method (can do)
        public void WeatherPicker()
        {
            // Generate random indexes for weather types.
            int mIndex = rnd.Next(differentWeatherTypes.Length); //will randomly pull from list/
            int zIndex = rnd.Next(differentWeatherTypes.Length); ////will randomly pull from list notice the difference index so tomorrow (may) be different from today

            // Display the result.
            Console.WriteLine("The forecast for today:  {0}", differentWeatherTypes[mIndex]);
            Console.WriteLine("Tomorrow it will be:     {0}", differentWeatherTypes[zIndex]);
            Console.ReadLine(); //here as a placeholder to get it to stay on the screen. A method will go here what you want to happen next 
            //return; want it to run the next method whenever i figure out what the next method is
        }
    }
}  //use this method or find a method that display days and add 1 until its day 7
   