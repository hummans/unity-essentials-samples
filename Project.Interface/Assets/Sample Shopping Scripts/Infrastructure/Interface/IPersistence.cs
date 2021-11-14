
using System;
using UniRx;

public interface IPersistence
{
    public IObservable<Unit> Save(Shopping shopping);
}

