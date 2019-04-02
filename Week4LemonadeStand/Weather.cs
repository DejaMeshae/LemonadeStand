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
        //Day Day; I thought I would something from the day class here
        Random rnd = new Random();
        string[] differentWeatherTypes = {"Sunny", "Rainy", "Cloudy"};


        ////member method (can do)
        public void WeatherPicker()
        {
            // Generate random indexes for weather types.
            int bIndex = rnd.Next(differentWeatherTypes.Length); //will randomly pull from list/

            // Display the result.
            Console.WriteLine("Forecast for today:  {0} \n", differentWeatherTypes[bIndex]);
            //Console.ReadLine(); //here as a placeholder to get it to stay on the screen. A method will go here what you want to happen next 
            //return; want it to run the next method whenever i figure out what the next method is
        }

        public void ActualWeather()//this method will display after player leaves the store and start selling
        {
            int aIndex = rnd.Next(differentWeatherTypes.Length); ////will randomly pull from list notice the difference index so tomorrow (may) be different from today
            Console.WriteLine("The weather for today is: {0}", differentWeatherTypes[aIndex]);
        }
    }
}  


