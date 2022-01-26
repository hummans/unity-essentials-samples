
using System;
using UniRx;
using UnityEngine;

public class SqlDatabaseGateway : IPersistence
{
    public IObservable<Unit> Save(Shopping shopping)
    {
        // Saving persistante information
        return Observable.Return(Unit.Default)
            .Delay(TimeSpan.FromSeconds(1))
            .Do(_ => Debug.Log($"Saving in sql database with total {shopping.totalPrice}."));
    }
}