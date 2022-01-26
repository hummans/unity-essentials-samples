using System.Collections;
using System.Collections.Generic;
using Commands;
using UnityEngine;

public class ChargeTurnCmd : MonoBehaviour, ICommand
{
    private MyCharacterData myCharacterData;
    private MyCharacterMotion myCharacterMotion;

    public ChargeTurnCmd(MyCharacterData myCharacterData, MyCharacterMotion myCharacterMotion)
    {
        this.myCharacterData = myCharacterData;
        this.myCharacterMotion = myCharacterMotion;
    }

    public void Execute()
    {
        if(myCharacterData.myCharacterEnergy.Value >= myCharacterData.maxEnergy)
            return;
        
        Debug.Log("[MyCharacter] " + "Updating energy in " + myCharacterData.myCharacterName.Value);
        myCharacterData.myCharacterEnergy.Value += myCharacterMotion.energyCost;
        myCharacterData.OnMotion.OnNext(myCharacterMotion);

        if(myCharacterData.myCharacterEnergy.Value >= myCharacterData.maxEnergy)
            myCharacterData.myCharacterEnergy.Value = myCharacterData.maxEnergy;
    }
}
