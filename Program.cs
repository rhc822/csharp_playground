using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using c_sharp_playground.Models;


namespace c_sharp_playground
{
    class Program
    {
        public static async Task Main()
        {
            // Weather API to get past seven day weather
            var a = await WeatherAPI.GetPastSevenDayWeather();
            
            // LINQ FUN
            await LINQ.LinqExample(a);

        }
    }
}
