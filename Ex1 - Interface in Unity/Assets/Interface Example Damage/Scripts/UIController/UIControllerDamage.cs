using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControllerDamage : MonoBehaviour
{
    private int numberRef;
    private ObjectType type;
    public Slider sliderVida;
    public TextMeshProUGUI textVida;
    
    private void Start() 
    {
        IObjectGame parentObject = GetComponentInParent<IObjectGame>();
        if(parentObject != null)
        {
            type = parentObject.typeObject;
            sliderVida.maxValue = parentObject.damageSystem.maxVida;
            sliderVida.value = parentObject.damageSystem.maxVida;
            numberRef = parentObject.objectNumberReference;
        } 
        else 
        {
            parentObject = GameObject.FindGameObjectWithTag("Player").GetComponent<IObjectGame>();
            type = parentObject.typeObject;
            sliderVida.maxValue = parentObject.damageSystem.maxVida;
            sliderVida.value = parentObject.damageSystem.maxVida;
            numberRef = parentObject.objectNumberReference;
        }

        Debug.Log("Object type in UI is: " + type);
        GameEvents.current.OnObjectVidaChange += OnVidaChange;
    }

    public void OnVidaChange(ObjectType type, int value, int damage, int numRef)
    {
        if(type == this.type && numRef == numberRef)
        {
            SetVida(value, damage);
        }
    }

    public void SetVida(int value, int damage)
    {
        sliderVida.value = value;
        textVida.text = damage.ToString();
    }
}
