using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    
    void Awake()
    {
        current = this;
    }

    public event Action<ObjectType, int, int, int> OnObjectVidaChange;
    public void OnVidaChange(ObjectType type, int value, int damage, int num)
    {
        if(OnObjectVidaChange != null)
            OnObjectVidaChange(type, value, damage, num);
    }
}

public enum ObjectType
{
    Enemy,
    Player,
    TowerDefense
}
