using System;
using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UniRx;
using UnityEngine;

public class PlayGateway : IPlayTurnGateway
{
    public IObservable<Unit> PlayTurn(int energyRemaining)
    {
        return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ => Debug.Log($"Sending to server remaining energy {energyRemaining}"));
    }
}
