using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MyCharacterMotion", menuName = "Scriptable/MyCharacterMotion")]
public class MyCharacterMotion : ScriptableObject
{
    public int energyCost;
    public string motionName;
}
