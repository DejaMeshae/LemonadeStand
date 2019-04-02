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
        //Random randomWeather = new Random();
        //public Weather()
        //{
        //    string[] differentWeatherTypes = { "Sunny", "Rainy", "Cloudy", "Overcast" }; //list of different weather types
        //}


        ////member method (can do)
        //public void PicksTheWeather(int min, int max)
        //{
        //    //random method goes here
        //    int mIndex = rnd.Next(malePetNames.Length);
        //}
        public void WeatherPicker()
        {
            Random rnd = new Random();
            string[] differentWeatherTypes = { "Sunny", "Rainy", "Cloudy", };

            // Generate random indexes for weather types.
            int mIndex = rnd.Next(differentWeatherTypes.Length);

            // Display the result.
            Console.WriteLine("The forecast for today:     {0}", differentWeatherTypes[mIndex]);
            Console.ReadLine();
        }
    }
}
