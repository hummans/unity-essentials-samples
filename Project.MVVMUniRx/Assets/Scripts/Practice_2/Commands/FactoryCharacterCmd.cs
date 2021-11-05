using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;

[CreateAssetMenu(fileName = "FactoryCharacterCmd", menuName = "Scriptable/FactoryCharacterCmd")]
public class FactoryCharacterCmd : ScriptableObject
{
    public PerfomMotionCmd PerfomMotion(MyCharacterData myCharacterData, MyCharacterMotion myCharacterMotion)
    {
        return new PerfomMotionCmd(myCharacterData, myCharacterMotion);
    }

    public ChargeTurnCmd TurnChargeEnergy(MyCharacterData myCharacterData, MyCharacterMotion myCharacterMotion)
    {
        return new ChargeTurnCmd(myCharacterData, myCharacterMotion);
    } 

    public PlayTurnCmd PlayTurn(MyCharacterData myCharacterData)
    {
        return new PlayTurnCmd(myCharacterData, new PlayTurnGateway());
    }
}
