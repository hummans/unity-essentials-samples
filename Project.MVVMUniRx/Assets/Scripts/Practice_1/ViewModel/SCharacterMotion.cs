using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

[CreateAssetMenu(fileName = "New Character Motion", menuName = "Scriptable/CharacterMotion")]
public class SCharacterMotion : ScriptableObject
{
    public string motionName;
    public int energyCost;
}
