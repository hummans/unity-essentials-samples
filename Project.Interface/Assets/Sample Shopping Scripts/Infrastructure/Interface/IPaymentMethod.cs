
using System;
using UniRx;

public interface IPaymentMethod
{
    public PaymentType PaymentType{ get; set;}
    public IObservable<Unit> Pay(Shopping shopping);
}
public enum PaymentType
{
    CreditCard,
    Paypal,
    MercadoPago,
    Cash
}