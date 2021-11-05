using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_InputField inputQuantity;
    public TMP_InputField inputPrice;
    public TMP_Dropdown dropdownPayment;

    [SerializeField] private Button _buttonAddToCard;
    [SerializeField] private Button _buttonBuy;
    [SerializeField] private ShoppingController _shoppingController;

    [SerializeField] private TextMeshProUGUI _textQuantity;
    [SerializeField] private TextMeshProUGUI _textPrice;

    void Start() 
    {
        _buttonAddToCard.onClick.AddListener(AddToCard);
        _buttonBuy.onClick.AddListener(Buy);
    }

    void AddToCard()
    {
        _shoppingController.AddToCart();

        _textPrice.text = "Price to pay: " + _shoppingController.GetCurrentCart().totalPrice;
        _textQuantity.text = "Quantity " + _shoppingController.GetCurrentCart().quantityProduct;
    }
    void Buy()
    {
        IPaymentMethod payment = _shoppingController.GetPaymentMethod(dropdownPayment.options[dropdownPayment.value].text);
        _shoppingController.BuyBasket(payment, new SqlDatabase());

        _textPrice.text = "Price to pay: " + _shoppingController.GetCurrentCart().totalPrice;
        _textQuantity.text = "Quantity " + _shoppingController.GetCurrentCart().quantityProduct;
    }
}
