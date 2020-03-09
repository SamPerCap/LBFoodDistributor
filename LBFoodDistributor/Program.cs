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
            string[] asianQueue = new string[3];
            asianQueue[0] = "http://localhost:54774/asianfood";
            asianQueue[1] = "http://localhost:54775/asianfood";
            asianQueue[2] = "http://localhost:54776/asianfood";


            string[] europeQueue = new string[2];
            europeQueue[0] = "http://localhost:56326/api/EFood";
            europeQueue[1] = "http://localhost:56327/api/EFood";

            string continent = "start";
            int iA = 0;
            int iE = 0;

            while (!continent.Equals("quit"))
            {
                Console.Write("Enter either Asia or Europe: ");
                continent = Console.ReadLine();

                if (continent.ToLower().Equals("asia"))
                {
                    if (iA == 3)
                        iA = 0;

                    GetInfo(asianQueue[iA]);
                    Console.WriteLine("APiUrl: " + asianQueue[iA] + "APiNumber: " + (iA + 1));
                    iA += 1;
                }
                else if (continent.ToLower().Equals("europe"))
                {
                    if (iE == 2)
                        iE = 0;

                    GetInfo(europeQueue[iE]);
                    Console.WriteLine("APiUrl: " + europeQueue[iE] + "APiNumber: " + (iE + 1));
                    iE += 1;
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


