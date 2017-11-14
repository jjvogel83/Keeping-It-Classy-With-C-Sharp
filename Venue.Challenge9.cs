//Challenge 9 (Method Overload)
//Venue.cs

using System;
using System.Collections.Generic;

public class Venue
{
    public string Name;
    public List<Band> Bands = new List<Band>();

    public void AddBand(string[] names)
    {
        foreach(var name in names)
        {
            AddBand(name);
        }
    }

    public void AddBand(string name)
    {
        Band band = new Band();
        band.Name = name;
        Bands.Add(band);
    }

    public void Announce()
    {
        Console.WriteLine(Name + " will have " + Bands.Count + " bands playing tonight!");

        foreach(var band in Bands)
        {
            band.Announce();
        }
    }
}

Band.cs
using System;

public class Band
{
    public string Name;

    public void Announce()
    {
        Console.WriteLine("Welcome " + Name + " to the stage!");
    }
}



Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your venue?");
        Venue venue = new Venue();
        venue.Name = "The Jazz Hut";
        string[] bandNames = {"Jazztallica", "Jazzadeth"};
        venue.AddBand(bandNames);
        venue.Announce();
    }
}
