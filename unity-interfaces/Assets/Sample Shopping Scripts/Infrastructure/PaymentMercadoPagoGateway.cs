using UnityEngine;
using UniRx;
using System;

public class MercadoPago : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public MercadoPago()
    {
        PaymentType = PaymentType.MercadoPago;
    }
    
    IObservable<Unit> IPaymentMethod.Pay(Shopping shopping)
    {
         return Observable.Return(Unit.Default)
                        .Delay(TimeSpan.FromSeconds(1))
                        .Do(_ =>  Debug.Log($"Payment products with {PaymentType}"));
    }
}
