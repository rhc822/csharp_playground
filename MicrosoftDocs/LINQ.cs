using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using c_sharp_playground.Models;
using System.Threading.Tasks;

namespace c_sharp_playground
{
    public class LINQ
    {

        public static async Task LinqExample(WeatherAPIRepo weatherList)
        {
            // Data source
            //int[] scores = new int[] { 97, 92, 81, 60 };
            List<WeatherAPIRepo.Forecastday> day = new List<WeatherAPIRepo.Forecastday>();
            foreach (var i in weatherList.forecast.forecastday)
            {
                day.Add(i);
            }


            // Query1
            IEnumerable<WeatherAPIRepo.Forecastday> highTempQuery =
                from temp in day
                where temp.day.maxtemp_f >= 70
                orderby temp.day.maxtemp_f ascending
                select temp;
            Console.Write($"High Temps in {weatherList.location.name} over 70 degrees Farenheit for the last seven days were:\n");
            foreach (var i in highTempQuery)
            {
                Console.WriteLine($"{i.date}: {i.day.maxtemp_f}\n");
            }



            /*



            // Query1
            IEnumerable<int> highScoreQuery = 
                from score in scores
                where score > 80
                orderby score ascending
                select score;

            foreach (int i in highScoreQuery)
            {

                Console.Write($"{i} {i.GetType()} \n");

            }

            // Query2
            IEnumerable<string> scoreString =
                from score in scores
                where score > 80
                orderby score descending
                select $"The score is {score}";

            foreach (string j in scoreString)
            {

                Console.Write($"{j} {j.GetType()}\n");

            }

            // Query3
            int highScoreCount =
                (from score in scores
                 where score > 80
                 select score)
                 .Count();
            Console.WriteLine(highScoreCount);

            // OR Query3 re-written "preferably" as...

            IEnumerable<int> highScoresQuery2 =
                from score in scores
                where score > 80
                select score;
            int scoreCount = highScoresQuery2.Count();
            Console.WriteLine(scoreCount);

            // Query4
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            foreach(int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }



            */



        }
    }
}
