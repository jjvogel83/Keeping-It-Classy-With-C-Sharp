//Challenge 5 (Calling a Class Method)
//Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your venue?");
        Venue venue = new Venue();
        venue.Name = "The Jazz Hut";
        venue.Announce();    }
}
