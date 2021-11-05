using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using System;

public class CharacterDisplayEnergy : MonoBehaviour
{
    public TextMeshProUGUI energyLabel;
    public SCharacterData characterData;

    public void Start()
    {
        characterData.energy
            .Subscribe(UpdateEnergy)
            .AddTo(this);
    }
    private void UpdateEnergy(int energy)
    {
        energyLabel.text = energy.ToString();
    }
}
