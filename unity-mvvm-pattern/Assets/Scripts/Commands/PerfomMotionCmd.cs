using System.Collections;
using System.Collections.Generic;
using Commands;
using UnityEngine;

public class PerfomMotionCmd : MonoBehaviour, ICommand
{
    private MyCharacterData myCharacterData;
    private MyCharacterMotion myCharacterMotion;

    public PerfomMotionCmd(MyCharacterData myCharacterData, MyCharacterMotion myCharacterMotion)
    {
        this.myCharacterData = myCharacterData;
        this.myCharacterMotion = myCharacterMotion;
    }

    public void Execute()
    {
        if(myCharacterData.myCharacterEnergy.Value == 0)
            return;
            
        Debug.Log("[MyCharacter] " + myCharacterData.myCharacterName + " is executing animation " + myCharacterMotion.motionName);
        myCharacterData.myCharacterEnergy.Value -= myCharacterMotion.energyCost;
        myCharacterData.OnMotion.OnNext(myCharacterMotion);

        if(myCharacterData.myCharacterEnergy.Value <= 0)
        {
            Debug.Log("[MyCharacter] " + myCharacterData.myCharacterName + " is game over!");
            myCharacterData.myCharacterEnergy.Value = 0;
        }
    }
}
