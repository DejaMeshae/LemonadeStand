using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day = new Day();  //instanciate this class
            day.DisplayTheDay(); //cycle through the day

            Weather weather = new Weather();  //instanciate this class
            weather.WeatherPicker();  //randomize weather
        }
    }
}
