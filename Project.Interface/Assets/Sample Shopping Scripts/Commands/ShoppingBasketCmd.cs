using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ShoppingBasketCmd : ICommand
{
    private Shopping shoppingData;
    private IPaymentMethod pay;
    private IPersistence persistence;

    public ShoppingBasketCmd(Shopping shoppingData, string paymentMethod, IPersistence persistence)
    {
        this.shoppingData = shoppingData;
        this.pay = GetPaymentMethod(paymentMethod);
        this.persistence = persistence;
    }
    
    public void Execute()
    {
        pay.Pay(shoppingData)
            .Do(_ =>  Debug.Log($"Quantity in buy is {shoppingData.quantityProduct.Value} products!"))
            .Do(_ =>  Debug.Log($"Total price is ${shoppingData.totalPrice.Value}"))
            .Do(_ => persistence.Save(shoppingData))
            .Subscribe(OnFinish);

    }
    
    private void OnFinish(Unit observable)
    {
        shoppingData.quantityProduct.Value = 0;
        shoppingData.totalPrice.Value = 0;
    }

    public IPaymentMethod GetPaymentMethod(string method) => method switch
    {
        "Credit Card" => new CreditCard(),
        "Mercado Pago" => new MercadoPago(),
        "Paypal" => new Paypal(),
        "Cash" => new Cash(),
        _ => new CreditCard()
    };
}