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
        Start:
            string apiUrl = "";
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            if (name.Equals("Asia"))
            {
                apiUrl = "http://localhost:54774/asianfood";
            }
            else if (name.Equals("Europe"))
            {
                apiUrl = "http://localhost:56326/api/EFood";
            }
            else
                Console.WriteLine("Try again lol");

             
            //var input = new
            //{
            //    Name = name,
            //};
           // string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            var json = client.DownloadData(apiUrl);
            string download = Encoding.ASCII.GetString(json);
            List<Food> customers = (new JavaScriptSerializer()).Deserialize<List<Food>>(download);
            if (customers.Count > 0)
            {
                foreach (Food customer in customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }
            else
            {
                Console.WriteLine("No records found.");
            }
            Console.WriteLine();
            goto Start;
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
