using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShoppingCartInput : MonoBehaviour
{
    public ShoppingCmdFactory shoppingCmdFactory;
    public Shopping shoppingData;

    public TMP_InputField inputQuantity;
    public TMP_InputField inputPrice;

    public void OnClick()
    {
        shoppingCmdFactory.CartAdd(shoppingData, Convert.ToInt32(inputQuantity.text), Convert.ToInt32(inputPrice.text)).Execute();
    }
}

