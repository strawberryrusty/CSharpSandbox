﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FEATURE!");

            Footballer Ronaldo = new Footballer("Giggs", "Manchester United", 25000000);
            Footballer VanPersie = new Footballer("Van Persie", "Arsenal", 130000);

            //Console.WriteLine(VanPersie.Club);
            //Console.WriteLine($"{VanPersie.Name} plays for {Ronaldo.Club} and is worth {Ronaldo.Value + 10000000}");

            /*IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "ONEONE"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            */

            /*foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            */

            //Console.WriteLine(numberNames[1]);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
              {"UK", "London, Manchester, Tokyo"},
              {"USA", "Chicago, New York, Washington"},
              {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine(cities["UK"]);

            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }

        }
    }
}
