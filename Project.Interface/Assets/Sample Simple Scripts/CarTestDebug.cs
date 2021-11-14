using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTestDebug : MonoBehaviour
{
    void Start()
    {
        Car car = new Car("Tesla", Automobile.Car, 150, 3);
        Truck truck = new Truck("Volvo RX125", Automobile.Truck, 450, 4);

        CarRun(car);
        CarRun(truck);
    }

    void CarRun(IAutomobile car)
    {
        car.Run();
        car.MaxDistance();
    }
}