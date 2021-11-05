using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingBasket
{
    IPaymentMethod _pay;
    IPersistence _persistence;

    public ShoppingBasket(IPaymentMethod pay, IPersistence persistence)
    {
        this._pay = pay;
        this._persistence = persistence;
    }
    
    public void Buy(Shopping shopping)
    {
        _persistence.Save(shopping);
        _pay.Pay(shopping);

        Debug.Log("Cantidad de compra: " + shopping.quantityProduct.ToString());
        Debug.Log("Precio total: " + shopping.totalPrice.ToString());
    }
}

public enum PaymentType
{
    CreditCard,
    Paypal,
    MercadoPago
}

public interface IPaymentMethod
{
    public PaymentType PaymentType{ get; set;}
    public void Pay(Shopping shopping);
}

public class Paypal : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public Paypal()
    {
        PaymentType = PaymentType.Paypal;
    }

    public void Pay(Shopping shopping)
    {
        Debug.Log("Pagando productos con paypal!");
    }
}

public class MercadoPago : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public MercadoPago()
    {
        PaymentType = PaymentType.MercadoPago;
    }

    public void Pay(Shopping shopping)
    {
        Debug.Log("Pagando productos con mercadopago!");
    }
}

public class CreditCard : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public CreditCard()
    {
        PaymentType = PaymentType.CreditCard;
    }

    public void Pay(Shopping shopping)
    {
        Debug.Log("Pagando productos con tarjeta de credito!");
    }
}

public class Cash : IPaymentMethod
{
    public PaymentType PaymentType {get; set;}

    public Cash()
    {
        PaymentType = PaymentType.CreditCard;
    }

    public void Pay(Shopping shopping)
    {
        Debug.Log("Pagando productos con efectivo!");
    }
}
