using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacterMotionInput : MonoBehaviour
{
    public MyCharacterData myCharacterData;
    public FactoryCharacterCmd factoryCharacterCmd;

    public void OnClick(MyCharacterMotion myCharacterMotion)
    {
        factoryCharacterCmd.PerfomMotion(myCharacterData, myCharacterMotion).Execute();
    }
}
