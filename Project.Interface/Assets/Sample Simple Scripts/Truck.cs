
using UnityEngine;

public class Truck : IAutomobile
{
    public Truck(string name, Automobile type, int litersKw, int distanceKw)
    {
        Name = name;
        Type = type;
        LitersKw = litersKw;
        KilometersKw = distanceKw;
    }

    public string Name { get; set; }
    public Automobile Type { get; set; }
    public int LitersKw { get; set; }
    public int KilometersKw { get; set; }

    public double Distance => LitersKw * KilometersKw;

    public void MaxDistance()
    {
        Debug.Log($"It's a {Type}");
        Debug.Log($"Maximum distance is {Distance} km");
    }
    public void Run()
    {
        Debug.Log($"{Name} is running! Let's go!");
        Debug.Log("We are turning on the oil motors!");
    }
}