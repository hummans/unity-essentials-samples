using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;

public class MyCharacterNameDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameLabel;
    public MyCharacterData myCharacterData;
    
    void Start()
    {
        myCharacterData.myCharacterName
            .Subscribe(UpdateName)
            .AddTo(this);
    }

    void UpdateName(string name)
    {
        nameLabel.text = name;  
    }
}
