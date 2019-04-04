using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Weather
    {
        //member variable
        string condition;
        int tempurature;

        //constructor (build this)
        //Day Day; I thought I would something from the day class here
        Random rnd = new Random();
        string[] differentWeatherTypes = {"Sunny", "Rainy", "Cloudy", "Foggy"};
        string[] differentTemperture = {"68", "56", "75", "82"};

        //public Weather() work on this so as ir calls a weather it will also call a temp
        //{
        //    condition = "Sunny";
        //    tempurature = WeatherPicker();
        //}


        ////member method (can do)
        public void WeatherPicker()
        {
            // Generate random indexes for weather types.
            int bIndex = rnd.Next(differentWeatherTypes.Length); //will randomly pull from list/
            int cIndex = rnd.Next(differentTemperture.Length); //will randomly pull from list/

            Console.WriteLine("Forecast for today:  {0}", differentWeatherTypes[bIndex] + " and " + differentTemperture[cIndex] + " degrees \n");
        }

        public void ActualWeather()//this method will display after player leaves the store and start selling
        {
            int aIndex = rnd.Next(differentWeatherTypes.Length); ////will randomly pull from list notice the difference index so tomorrow (may) be different from today
            int cIndex = rnd.Next(differentTemperture.Length); //will randomly pull from list/

            Console.WriteLine("The weather for today is: {0}", differentWeatherTypes[aIndex] + " and " + differentTemperture[cIndex] + " degrees \n");
        }

        //public void TemperturePicker() //instead of creating a seperate method just joined weather picker method
        //{
        //    // Generate random indexes for weather types.
        //    int cIndex = rnd.Next(differentTemperture.Length); //will randomly pull from list/
        //    Console.WriteLine("Temperture for today:  {0} \n", differentTemperture[cIndex]);
        //}

    }
}  


