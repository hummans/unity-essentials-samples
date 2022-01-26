using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CharacterInputMotion : MonoBehaviour
{
    public CharacterFactoryCmd cmdFacotry;
    public SCharacterData characterData;

    public void OnClick(SCharacterMotion motion)
    {
        cmdFacotry.PerfomMotion(characterData, motion).Execute();
    }
}
