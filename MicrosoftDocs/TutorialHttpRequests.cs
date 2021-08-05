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

    /********************************
 * 
 * TUTORIAL: MAKE HTTP REQUESTS IN A .NET CONSOLE APP USING C# 
 * https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
 * 
 * 
 * *********************************/


    public class TutorialHttpRequests
    {

        private static readonly HttpClient client = new HttpClient();

        private static async Task<List<TutorialHttpRequestsRepo>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<TutorialHttpRequestsRepo>>(await streamTask);
            
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

            return repositories;
        }
    }


    public class TutorialHttpRequestsRepo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }
        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }
        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }
        [JsonPropertyName("pushed_at")]
        public DateTime LastPushUtc { get; set; }
        //public DateTime LastPush => LastPushUtc.ToLocalTime();
    }
}
