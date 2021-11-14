
public interface IAutomobile
{
    string Name {get; set;}
    Automobile Type {get; set;}
    int LitersKw {get; set;}
    int KilometersKw {get; set;}

    void Run();
    void MaxDistance();

    double Distance
    {
        get;
    }
}

public enum Automobile
{
    Car,
    Motocycle,
    Truck,
    PickUp
}

