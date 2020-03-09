using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LBFoodDistributor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.ReadLine().Equals("quit"))
            {
                Console.Write("Enter either Asia or Europe: ");
                string name = Console.ReadLine();

                if (name.ToLower().Contains("asia"))
                {
                    GetInfo("http://localhost:56326/api/asianFood");
                }
                else if (name.ToLower().Contains("europe") || name.ToLower().Contains("eu"))
                {
                    GetInfo("http://localhost:56326/api/EFood");
                }
                else
                {
                    Console.WriteLine("Command not identified");
                }
            }
        }

        public static void GetInfo(string apiUrl)
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            var json = client.DownloadData(apiUrl);
            string download = Encoding.ASCII.GetString(json);
            List<Food> foodType = (new JavaScriptSerializer()).Deserialize<List<Food>>(download);
            if (foodType.Count > 0)
            {
                foreach (Food food in foodType)
                {
                    Console.WriteLine($"Food name: {food.Name}\n" +
                        $"Food Continent: {food.Continent}\n" +
                        $"Food Country: {food.Country}\n");
                }
            }
            else
            {
                Console.WriteLine("No records found.");
            }
        }

        public class Food
        {
            public int Id { get; set; }
            public string Name { get; set; }
            //public IList<string> Ingredients { get; set; }
            public string Country { get; set; }
            public string Continent { get; set; }
        }
    }
}


