using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShoppingCmdFactory", menuName = "Scriptable/Shopping/Shopping Factory")]
public class ShoppingCmdFactory : ScriptableObject
{
    public ShoppingBasketCmd PayBasket(Shopping shopping, string payment)
    {
        return new ShoppingBasketCmd(shopping, payment, new SqlDatabaseGateway());
    }
    public ShoppingCartCmd CartAdd(Shopping shopping, int quantity, int price)
    {
        return new ShoppingCartCmd(shopping, quantity, price);
    }
}