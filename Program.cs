using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebAPIClient;


namespace c_sharp_playground
{
    class Program
    {



        /********************************
         * 
         * TUTORIAL: MAKE HTTP REQUESTS IN A .NET CONSOLE APP USING C# 
         * https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
         * 
         * 
        private static readonly HttpClient client = new HttpClient();

        private static async Task<List<HTTPTutorialRepository>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<HTTPTutorialRepository>>(await streamTask);
            return repositories;
        }
        *********************************/

        private static readonly HttpClient client = new HttpClient();

        //private static async Task<List<WeatherAPIRepo>> ProcessRepositories()
        private static async Task ProcessRepositories()
        {
            Console.WriteLine("Enter a location");
            string location = Console.ReadLine();
            Console.WriteLine("Enter a start date (use the YYYY-MM-DD format AND ensure the date is within the last 7 days)");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter an end date (use the YYYY-MM-DD format AND ensure the date is within the last 7 days)");
            string endDate = Console.ReadLine();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "3a62bb364emshfe24fb90cd88c07p1f19bejsn24d536260e98");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherapi-com.p.rapidapi.com");

            var streamTask = client.GetStreamAsync($"https://weatherapi-com.p.rapidapi.com/history.json?q={location}&dt={startDate}&lang=en&end_dt={endDate}");
            var repositories = await JsonSerializer.DeserializeAsync<WeatherAPIRepo>(await streamTask);

                    
            foreach(var a in repositories.forecast.forecastday) { Console.WriteLine(a.day.maxtemp_f); }
            
            

            //var stringTask = client.GetStringAsync($"https://weatherapi-com.p.rapidapi.com/history.json?q={location}&dt={startDate}&lang=en&end_dt={endDate}");
            //var msg = await stringTask;
            //Console.WriteLine(msg);
            //var repositories = JsonSerializer.Deserialize<WeatherAPIRepo>(msg);
            //Console.WriteLine(repositories.location.name);
            //return repositories;
        }




        public static async Task Main()
        {


            //var repositories = await ProcessRepositories();
            await ProcessRepositories();

            //foreach (var repo in repositories)
            //{
            //    Console.WriteLine(repo.Name);
            //}

                //var client = new HttpClient();
                //var request = new HttpRequestMessage
                //{
                //    Method = HttpMethod.Get,
                //    RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/history.json?q=Nashville&dt=2021-07-26&lang=en&hour=1&end_dt=2021-07-26"),
                //    Headers =
                //    {
                //        { "x-rapidapi-key", "3a62bb364emshfe24fb90cd88c07p1f19bejsn24d536260e98" },
                //        { "x-rapidapi-host", "weatherapi-com.p.rapidapi.com" },
                //    },
                //};
                //using (var response = await client.SendAsync(request))
                ////using (var response = await client.GetStreamAsync(request))
                //{
                //    response.EnsureSuccessStatusCode();
                //    var body = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine(body);

                //}







                // TUTORIAL: MAKE HTTP REQUESTS IN A.NET CONSOLE APP USING C#
                // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
                /*************************
                var repositories = await ProcessRepositories();

                foreach (var repo in repositories)
                {
                    Console.WriteLine(repo.Name);
                    Console.WriteLine(repo.Description);
                    Console.WriteLine($"GitHub home URL: {repo.GitHubHomeUrl}");
                    Console.WriteLine($"URL homepage: {repo.Homepage}");
                    Console.WriteLine($"Watchers: {repo.Watchers}");
                    Console.WriteLine(repo.LastPushUtc);
                    Console.WriteLine();
                }
                ****************************/

                // LINQ FUN
                //LINQ.LinqExample();

                // TRY/CATCH FUN!
                // Throw keyword and custom error
                //Console.WriteLine("Enter Value1");
                //string value1 = Console.ReadLine();
                //checkValue1(value1);
                //static void checkValue1(string value1)
                //{
                //    string pattern = "[a-zA-Z]";
                //    Regex regex = new Regex(pattern);
                //    MatchCollection match = regex.Matches(value1);
                //    if (match.Count > 0)
                //    {
                //        throw new FormatException("Please, your life depends on you entering a number.");
                //    }
                //    else
                //    {
                //        Convert.ToInt32(value1);
                //    }
                //}
                //Console.WriteLine("Enter Value2");
                //string value2 = Console.ReadLine();
                //checkValue2(value2);
                //static void checkValue2(string value2)
                //{
                //    string pattern = "[a-zA-Z]";
                //    Regex regex = new Regex(pattern);
                //    MatchCollection match = regex.Matches(value2);
                //    if (match.Count > 0)
                //    {
                //        throw new FormatException("Please, your life depends on you entering a number.");
                //    }
                //    else
                //    {
                //        Convert.ToInt32(value2);
                //    }
                //}



                //int value1 = Convert.ToInt32(Console.ReadLine());
                //if (value1.)
                //{
                //    throw new FormatException ("You must enter a number.");
                //}
                //else
                //{
                //    Console.WriteLine("All clear. Enter numbers to your heart's content.");
                //}
                //try
                //{
                //    double value1 = Convert.ToInt32(Console.ReadLine());
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e);
                //}
                //finally
                //{
                //    Console.WriteLine("This is the 'finally' statement");
                //}
                //Console.WriteLine("Enter Value2");
                //int value2 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine();

                // FILE TEST
                //FileTest FileTest = new FileTest();
                //FileTest.FileTestCreation();
                //FileTest.FileFun();

                // ENUMS
                //EnumTest test = EnumTest.high; // Assign to variable
                //Console.WriteLine($"Accessing the enum as it's own 'class': {test}");
                //Console.WriteLine($"enum value is: {(int) test}\nand it's type is: {test.GetType()}"); // 
                //EnumTestClass test2 = new EnumTestClass(); // Enums in classes are static and you can't access them through instantiation
                //Console.WriteLine($"Accessing the enum inside another class: {(int) EnumTestClass.Dates.June}\nand it's type is: {EnumTestClass.Dates.December.GetTypeCode()}"); // Must use the whole path to access the 
                //switch (test)
                //{
                //    case EnumTest.low:
                //        Console.WriteLine("The chlorine levels are low. You're gonna have algae problems brother.");
                //        break;
                //    case EnumTest.medium:
                //        Console.WriteLine("The chlorine levels are medium. Have a good time and enjoy the pool. It's fun.");
                //        break;
                //    case EnumTest.high:
                //        Console.WriteLine("The chlorine levels are too high. Get out of the pool or you will die!");
                //        break;
                //}


                // INTERFACE
                //Console.WriteLine("Enter the animal name");
                //string animalName = Console.ReadLine();
                //Console.WriteLine("Enter the animal sound");
                //string animalSound = Console.ReadLine();
                //InterfaceImplementationClass interfaceImplementationClass = new InterfaceImplementationClass(animalName, animalSound);
                //interfaceImplementationClass.animalSound();

                // ABSTRACT
                //var myAbstractClass = new AbstractClass();


                // POLYMORPHISM
                //Console.WriteLine("Enter the make of the vehicle");
                //string make = Console.ReadLine();
                //Console.WriteLine("Enter the model of the vehicle");
                //string model = Console.ReadLine();
                //Class_BaseParent myPolymorphismExample1 = new Class_DerivedChild(model, make);
                //Console.WriteLine("Enter ANOTHER vehicle make");
                //make = Console.ReadLine();
                //Console.WriteLine("Enter ANOTHER vehicle model");
                //model = Console.ReadLine();
                //Class_BaseParent myPolymorphismExample2 = new Class_DerivedChild2(model, make);
                ////Class_BaseParent myPolymorphismBase = new Class_BaseParent();
                //Class_BaseParent myPolymorhismExample3 = new Class_DerivedChild3(model, make);
                ////Console.WriteLine($"You have won a/an {myPolymorphismExample1.Make} {myPolymorphismExample1._modelName} {myPolymorphismExample1.honk()}\nAND\na/an {myPolymorphismExample2.Make} {myPolymorphismExample2._modelName} {myPolymorphismExample2.honk()}");
                //// myPolymorphismBase.honk();
                //myPolymorphismExample1.honk();
                //myPolymorphismExample2.honk();
                //myPolymorhismExample3.honk();


                // CLASS PROPERTIES
                //Console.WriteLine("Enter a name");
                //string firstName = Console.ReadLine();
                //Console.WriteLine("Enter an age");
                //int enteredAge = Convert.ToInt32(Console.ReadLine());

                //var Properties = new Properties();
                //Properties.Name = firstName;
                //Properties.Age = enteredAge;
                //Console.WriteLine($"Hello, I am '{Properties.Name}', and I am {Properties.Age}. I work at {Properties.Workplace}");

                //var Methods = new Methods();
                //Console.WriteLine(Methods.MethodOverloadingExample("Chloe", "Pilkerton", "CEO", 20));
                // Methods.MethodsExample1(test4: 1.234, test3: 21, test: "Bob"); // Named arguemnts enables them to occur in any position in the method call

            }


    }
}
