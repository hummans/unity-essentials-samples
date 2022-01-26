using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterChargeInput : MonoBehaviour
{
    public FactoryCharacterCmd factoryCharacterCmd;
    public MyCharacterData myCharacterData;
    
    public void OnClick(MyCharacterMotion myCharacterMotion)
    {
        factoryCharacterCmd.TurnChargeEnergy(myCharacterData, myCharacterMotion).Execute()  ;
    }
}
