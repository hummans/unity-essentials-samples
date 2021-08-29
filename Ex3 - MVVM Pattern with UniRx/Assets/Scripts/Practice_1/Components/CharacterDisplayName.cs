using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;

public class CharacterDisplayName : MonoBehaviour
{
    public TextMeshProUGUI nameLabel;
    public SCharacterData characterData;

    void Start()
    {
        characterData.characterName
            .Subscribe(UpdateName)
            .AddTo(this);
    }

    private void UpdateName(string characterName)
    {
        nameLabel.text = characterName;
    }
}
