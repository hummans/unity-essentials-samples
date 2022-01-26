using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShoppingBuyInput : MonoBehaviour
{
    public ShoppingCmdFactory shoppingCmdFactory;
    public Shopping shoppingData;
    public TMP_Dropdown dropdownPayment;    
    
    public void OnClick()
    {
        string payment = dropdownPayment.options[dropdownPayment.value].text;
        shoppingCmdFactory.PayBasket(shoppingData, payment).Execute();
    }
}

