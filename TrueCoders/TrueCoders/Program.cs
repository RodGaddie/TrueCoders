using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var charlie = new people();
            var harrison = new people();
            var troy = new people();
            var rod = new people();

            charlie.Age = 25;
            charlie.FirstName = "Charlie";
            charlie.LastName = "Doyle";
            charlie.HairColor = "Black";

            harrison.Age = 18;
            harrison.FirstName = "Harrison";
            harrison.LastName = "Rodriguez";
            harrison.HairColor = "Brown";

            troy.Age = 30;
            troy.FirstName = "Troy";
            troy.LastName = "Maxwell";
            troy.HairColor = "brown";

            rod.Age = 30;
            rod.FirstName = "Rod";
            rod.LastName = "Gaddie";
            rod.HairColor = "Brown";

            List<people> People = new List<people>();

            People.Add(charlie);
            People.Add(harrison);
            People.Add(troy);
            People.Add(rod);

            foreach (people person in People)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Haircolor: {person.HairColor}");
            }
        }
    }
}
