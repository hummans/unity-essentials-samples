using System;
using UniRx;
using UnityEngine;

public class Cash : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public Cash()
    {
        PaymentType = PaymentType.Cash;
    }

    IObservable<Unit> IPaymentMethod.Pay(Shopping shopping)
    {
         return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ =>  Debug.Log($"Payment products with {PaymentType}"));
    }
}
