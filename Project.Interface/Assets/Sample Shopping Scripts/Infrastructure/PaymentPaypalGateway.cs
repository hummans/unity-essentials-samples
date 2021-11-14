using System;
using UniRx;
using UnityEngine;

public class Paypal : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public Paypal()
    {
        PaymentType = PaymentType.Paypal;
    }

    IObservable<Unit> IPaymentMethod.Pay(Shopping shopping)
    {
         return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ =>  Debug.Log($"Payment products with {PaymentType}"));
    }
}
