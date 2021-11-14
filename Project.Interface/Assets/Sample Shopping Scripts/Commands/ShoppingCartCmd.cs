using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCartCmd : ICommand
{
    private Shopping shoppingData;
    private int quantity;
    private int price;

    public ShoppingCartCmd(Shopping shoppingData, int quantity, int price)
    {
        this.shoppingData = shoppingData;
        this.quantity = quantity;
        this.price = price;
    }

    public void Execute()
    {
        Debug.Log($"Adding to cart {quantity} products with a price ${price}.");
        shoppingData.quantityProduct.Value += Convert.ToInt32(quantity);
        shoppingData.totalPrice.Value += (Convert.ToInt32(price) * Convert.ToInt32(quantity));
    }
}
