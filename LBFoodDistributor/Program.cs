using Nancy.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LBFoodDistributor
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> asianQueue = new Queue<string>();
            Queue<string> europeanQueue = new Queue<string>();

            string continent = "start";

            while (!continent.Equals("quit"))
            {


                Console.Write("Enter either Asia or Europe: ");
                continent = Console.ReadLine();

                if (continent.ToLower().Equals("asia"))
                {
                    if (asianQueue.Count == 0)
                    {
                        asianQueue.Enqueue("http://localhost:54774/asianfood");
                        asianQueue.Enqueue("http://localhost:54775/asianfood");
                        asianQueue.Enqueue("http://localhost:54776/asianfood");
                    }
                    Console.WriteLine("APIURL: " + asianQueue.Peek());
                    Console.WriteLine("How many API's are in queue: " + asianQueue.Count);
                    GetInfo(asianQueue.Peek());
                    asianQueue.Dequeue();
                }
                else if (continent.ToLower().Equals("europe"))
                {
                    if (europeanQueue.Count == 0)
                    {
                        europeanQueue.Enqueue("http://localhost:56326/api/EFood");
                        europeanQueue.Enqueue("http://localhost:56327/api/EFood");
                    }
                    Console.WriteLine("APIURL: " + europeanQueue.Peek());
                    Console.WriteLine("How many API's are in queue: " + europeanQueue.Count);
                    GetInfo(europeanQueue.Peek());
                    europeanQueue.Dequeue();
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


