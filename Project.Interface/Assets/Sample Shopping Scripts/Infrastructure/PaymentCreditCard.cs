using System;
using UniRx;
using UnityEngine;

public class CreditCard : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public CreditCard()
    {
        PaymentType = PaymentType.CreditCard;
    }
    
    IObservable<Unit> IPaymentMethod.Pay(Shopping shopping)
    {
         return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ =>  Debug.Log($"Payment products with {PaymentType}"));
    }
}