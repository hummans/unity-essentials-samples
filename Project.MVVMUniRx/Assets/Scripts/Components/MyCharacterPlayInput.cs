using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterPlayInput : MonoBehaviour
{
    public FactoryCharacterCmd factoryCharacterCmd;
    public MyCharacterData myCharacterData;

    public void OnClick()
    {
        factoryCharacterCmd.PlayTurn(myCharacterData).Execute();
    }
}
