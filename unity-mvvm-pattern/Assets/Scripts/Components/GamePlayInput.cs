using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayInput : MonoBehaviour
{
    public CharacterFactoryCmd cmdFactory;
    public SCharacterData characterData;

    public void OnClick()
    {
        cmdFactory.PlayTurn(characterData).Execute();
    }
}
