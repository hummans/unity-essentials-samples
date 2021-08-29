using System.Collections;
using System.Collections.Generic;
using Commands;
using UnityEngine;

public class CmdPerfomMotion : ICommand
{
    private SCharacterData characterData;
    private SCharacterMotion motion;

    public CmdPerfomMotion(SCharacterData characterData, SCharacterMotion motion)
    {
        this.characterData = characterData;
        this.motion = motion;
    }
    
    public void Execute()
    {
        characterData.energy.Value -= motion.energyCost;
        characterData.OnMotion.OnNext(motion);

        if(characterData.energy.Value <= 0)
        {
            // Game Over
            Debug.Log("Game over");
            characterData.energy.Value = 0;
        }
    }
}
