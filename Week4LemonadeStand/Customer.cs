using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4LemonadeStand
{
    public class Customer
    {
        //member variable
        Random random;
        double percent = 100;
        double chanceToBuy;
        public bool buy;
        double weatherProbability;
        double temperatureProbability;

        //constructor
        public Customer()
        {

        }

        ////member method
        public void ChanceToBuyTemperature(Weather weather)
        {
            if (weather.temperature <= 75)
            {
                temperatureProbability = percent * 1.15;
            }
            else if (weather.temperature >= 56)
            {
                temperatureProbability = percent * 1.30;
            }
            else if (weather.temperature >= 68)
            {
                temperatureProbability = percent * 1.50;
            }
        }

        public void ChanceToBuyWeather(Weather weather)
        {
            if (weather.weather == "Sunny")
            {
                weatherProbability = percent * 1.85;
            }
            else if (weather.weather == "Rainy")
            {
                weatherProbability = percent * 1.45;
            }
            else if (weather.weather == "rainy")
            {
                weatherProbability = percent * 1.15;
            }
        }

        public bool CustomerBuysLemonade(int randomValue)
        {
            int value = 100;
            if (chanceToBuy <= value)
            {
                buy = false;
            }
            else
            {
                buy = true;
            }
            return this.buy;
        }

    }
}