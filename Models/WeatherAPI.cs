using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace c_sharp_playground.Models
{
    public class WeatherAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<WeatherAPIRepo> GetPastSevenDayWeather()
        //public static async Task<List<float>> GetPastSevenDayWeather()
        {
            Console.WriteLine("Enter a location");
            string location = Console.ReadLine();
            string endDate = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            string startDate = DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "3a62bb364emshfe24fb90cd88c07p1f19bejsn24d536260e98");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherapi-com.p.rapidapi.com");

            var streamTask = client.GetStreamAsync($"https://weatherapi-com.p.rapidapi.com/history.json?q={location}&dt={startDate}&lang=en&end_dt={endDate}");
            var repositories = await JsonSerializer.DeserializeAsync<WeatherAPIRepo>(await streamTask);
            return repositories;

            // API CALL, RETURN STRING INSTEAD OF STREAM 
            //var stringTask = client.GetStringAsync($"https://weatherapi-com.p.rapidapi.com/history.json?q={location}&dt={startDate}&lang=en&end_dt={endDate}");
            //var msg = await stringTask;
            //Console.WriteLine(msg);
            //var repositories = JsonSerializer.Deserialize<WeatherAPIRepo>(msg);
            //Console.WriteLine(repositories.location.name);
            //return repositories;

        }

    }

        public class WeatherAPIRepo
    {


        public Location location { get; set; }
        public Forecast forecast { get; set; }

        public class Location
        {
            public string name { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public float lat { get; set; }
            public float lon { get; set; }
            public string tz_id { get; set; }
            public int localtime_epoch { get; set; }
            public string localtime { get; set; }
        }

        public class Forecast
        {
            public Forecastday[] forecastday { get; set; }
        }

        public class Forecastday
        {
            public string date { get; set; }
            public int date_epoch { get; set; }
            public Day day { get; set; }
            public Astro astro { get; set; }
            public Hour[] hour { get; set; }
        }

        public class Day
        {
            public float maxtemp_c { get; set; }
            public float maxtemp_f { get; set; }
            public float mintemp_c { get; set; }
            public float mintemp_f { get; set; }
            public float avgtemp_c { get; set; }
            public float avgtemp_f { get; set; }
            public float maxwind_mph { get; set; }
            public float maxwind_kph { get; set; }
            public float totalprecip_mm { get; set; }
            public float totalprecip_in { get; set; }
            public float avgvis_km { get; set; }
            public float avgvis_miles { get; set; }
            public float avghumidity { get; set; }
            public Condition condition { get; set; }
            public float uv { get; set; }
        }

        public class Condition
        {
            public string text { get; set; }
            public string icon { get; set; }
            public int code { get; set; }
        }

        public class Astro
        {
            public string sunrise { get; set; }
            public string sunset { get; set; }
            public string moonrise { get; set; }
            public string moonset { get; set; }
            public string moon_phase { get; set; }
            public string moon_illumination { get; set; }
        }

        public class Hour
        {
            public int time_epoch { get; set; }
            public string time { get; set; }
            public float temp_c { get; set; }
            public float temp_f { get; set; }
            public int is_day { get; set; }
            public Condition1 condition { get; set; }
            public float wind_mph { get; set; }
            public float wind_kph { get; set; }
            public int wind_degree { get; set; }
            public string wind_dir { get; set; }
            public float pressure_mb { get; set; }
            public float pressure_in { get; set; }
            public float precip_mm { get; set; }
            public float precip_in { get; set; }
            public int humidity { get; set; }
            public int cloud { get; set; }
            public float feelslike_c { get; set; }
            public float feelslike_f { get; set; }
            public float windchill_c { get; set; }
            public float windchill_f { get; set; }
            public float heatindex_c { get; set; }
            public float heatindex_f { get; set; }
            public float dewpoint_c { get; set; }
            public float dewpoint_f { get; set; }
            public int will_it_rain { get; set; }
            public int chance_of_rain { get; set; }
            public int will_it_snow { get; set; }
            public int chance_of_snow { get; set; }
            public float vis_km { get; set; }
            public float vis_miles { get; set; }
            public float gust_mph { get; set; }
            public float gust_kph { get; set; }
        }

        public class Condition1
        {
            public string text { get; set; }
            public string icon { get; set; }
            public int code { get; set; }
        }

    }

}
