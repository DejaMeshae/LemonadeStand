using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Weather
    {
        //member variable
        public int temperature;
        public string weather;
        Random random;


        //constructor (build this)
        Random rnd = new Random();
        public string[] DifferentWeatherTypes = { "Sunny", "Rainy", "Cloudy" }; //this is an array i changed to to a string at the bottom
        public int [] DifferentTemperture = new int[] { 68, 56, 75 };
        public Weather(Random random)
        {
            this.random = random;
        }

        //member method (can do)
        public void TodayTemperature()
        { 
            int TodayTemperature = random.Next(0, DifferentTemperture.Length);
            temperature = DifferentTemperture[TodayTemperature];
        }

        public void WeatherPicker()
        {
            // Generate random indexes for weather types.
            int bIndex = rnd.Next(DifferentWeatherTypes.Length); //will randomly pull from list/
            int cIndex = rnd.Next(DifferentTemperture.Length); //will randomly pull from list/

            Console.WriteLine("Forecast for today:  {0}", DifferentWeatherTypes[bIndex] + " and " + DifferentTemperture[cIndex] + " degrees \n");
        }

        public void ActualWeather()//this method will display after player leaves the store and start selling
        {
            int aIndex = rnd.Next(DifferentWeatherTypes.Length); ////will randomly pull from list notice the difference index so tomorrow (may) be different from today
            int cIndex = rnd.Next(DifferentTemperture.Length); //will randomly pull from list/

            Console.WriteLine("The actual weather for today is: {0}", DifferentWeatherTypes[aIndex] + " and " + DifferentTemperture[cIndex] + " degrees \n");
        }

        //public void TemperturePicker() //instead of creating a seperate method just joined weather picker method
        //{
        //    // Generate random indexes for weather types.
        //    int cIndex = rnd.Next(differentTemperture.Length); //will randomly pull from list/
        //    Console.WriteLine("Temperture for today:  {0} \n", differentTemperture[cIndex]);
        //}

    }
}  


