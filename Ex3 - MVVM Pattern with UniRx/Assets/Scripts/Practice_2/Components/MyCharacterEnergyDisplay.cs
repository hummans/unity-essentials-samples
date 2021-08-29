using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UniRx;

public class MyCharacterEnergyDisplay : MonoBehaviour
{
    public TextMeshProUGUI energyLabel;
    public MyCharacterData myCharacterData;

    void Start()
    {
        myCharacterData.myCharacterEnergy
            .Subscribe(UpdateEnergy)
            .AddTo(this);    
    }

    void UpdateEnergy(int energy)
    {
        energyLabel.text = energy.ToString();
    }
}
