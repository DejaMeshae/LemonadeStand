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

        //constructor
        public Customer()
        {

        }

        //Need to test
        //public void ChanceToBuyTemperature(Weather weather)
        //{
        //    if (weather.temperature <= 75)
        //    {
        //        temperatureProbability = percent * 1.15;
        //    }
        //    else if (weather.temperature >= 56)
        //    {
        //        temperatureProbability = percent * 1.50;
        //    }
        //    else if (weather.temperature >= 68)
        //    {
        //        temperatureProbability = percent * 1.30;
        //    }
        //}

        ////member method
        //public void ChanceToBuyCondtion(Weather weather)
        //{
        //    if (weather.condition == "sunny")
        //    {
        //        conditionProbability = percent * 1.85;
        //    }
        //    else if (weather.condition == "cloudy" || weather.condition == "partly cloudy")
        //    {
        //        conditionProbability = percent * 1.45;
        //    }
        //    else if (weather.condition == "rainy" || weather.condition == "foggy")
        //    {
        //        conditionProbability = percent * 1.15;
        //    }
        //}



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