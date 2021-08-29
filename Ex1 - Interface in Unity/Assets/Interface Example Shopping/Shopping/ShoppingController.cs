using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingController : MonoBehaviour
{
    public UIController UI;

    ShoppingBasket _shoppingBasket;
    Shopping _shopping;

    void Start()
    {
        _shopping = new Shopping();
    }

    public void AddToCart()
    {
        _shopping.quantityProduct += Convert.ToInt32(UI.inputQuantity.text);
        _shopping.totalPrice += (Convert.ToInt32(UI.inputPrice.text) * Convert.ToInt32(UI.inputQuantity.text));
    }

    public void BuyBasket(IPaymentMethod pay, IPersistence persistence)
    {
        try
        {
            _shoppingBasket = new ShoppingBasket(pay, persistence);
            _shoppingBasket.Buy(_shopping);
        }
        catch(Exception ex)
        {
            Debug.Log(ex);
        }
        finally
        {
            _shopping.quantityProduct = 0;
            _shopping.totalPrice = 0;
        }
    }
    public IPaymentMethod GetPaymentMethod(string method)
    {
        IPaymentMethod payment;
        switch(method)
        {
            case "Credit Card":
                payment = new CreditCard();
                break;
            case "Mercado Pago":
                payment = new MercadoPago();
                break;
            case "Paypal":
                payment = new Paypal();
                break;
            default:
                payment = new CreditCard();
                break;
        }
        return payment;
    }
    public Shopping GetCurrentCart()
    {
        return _shopping;
    }
}
