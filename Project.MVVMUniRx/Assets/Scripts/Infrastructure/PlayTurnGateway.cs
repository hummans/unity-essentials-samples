using System;
using Infrastructure;
using UniRx;
using UnityEngine;

public class PlayTurnGateway : MonoBehaviour, IPlayTurnGateway
{    
    public IObservable<Unit> PlayTurn(int energyRemaining)
    {
        return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ => Debug.Log($"[PlayTurnGateway] Sending to server remaining energy {energyRemaining}"));
    }
}
