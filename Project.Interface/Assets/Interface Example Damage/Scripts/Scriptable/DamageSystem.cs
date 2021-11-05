using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Damage System", menuName = "Scriptable/New Damage System")]
public class DamageSystem : ScriptableObject
{
    public int maxVida;
    public int warningVida;

    public int GetMaxVida()
    {
        return maxVida;
    }
}
