using UniRx;
using UnityEngine;

[CreateAssetMenu(fileName = "Shopping", menuName = "Scriptable/Shopping/Shopping Data")]
public class Shopping : ScriptableObject
{
    public IntReactiveProperty quantityProduct;
    public IntReactiveProperty totalPrice;
}