using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacterBarDisplay : MonoBehaviour
{    
    public Slider slider;
    public Image fillBar;
    public MyCharacterData myCharacterData;
    public Sprite[] spriteBar;

    void Start()
    {
        myCharacterData.myCharacterEnergy
            .Subscribe(UpdateBar)
            .AddTo(this);    
    }

    void UpdateBar(int energy)
    {
        slider.value = energy;
        if(energy <= 50)
        {
            fillBar.sprite = spriteBar[1];
        } 
        else 
        {
            fillBar.sprite = spriteBar[0];
        }
    }
}
