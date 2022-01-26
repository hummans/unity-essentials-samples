using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UniRx;

public class ShoppingDataDisplay : MonoBehaviour
{
    public Shopping shoppingData;

    [SerializeField] private TextMeshProUGUI _textQuantity;
    [SerializeField] private TextMeshProUGUI _textPrice;

    void Start() 
    {
        shoppingData.quantityProduct
            .Subscribe(OnQuantityChange)
            .AddTo(this);

        shoppingData.totalPrice
            .Subscribe(OnPriceChange)
            .AddTo(this);
    }

    void OnPriceChange(int price)
    {
        _textPrice.text = $"Price to pay: {shoppingData.totalPrice}";
    }
    void OnQuantityChange(int quantity)
    {
        _textQuantity.text = $"Quantity: {shoppingData.quantityProduct}";
    }
}
