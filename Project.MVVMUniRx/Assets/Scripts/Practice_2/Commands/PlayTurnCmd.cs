using System.Collections;
using System.Collections.Generic;
using Commands;
using Infrastructure;
using UniRx;
using UnityEngine;

public class PlayTurnCmd : MonoBehaviour, ICommand
{
    private MyCharacterData myCharacterData;
    private IPlayTurnGateway playTurnGateway;

    public PlayTurnCmd(MyCharacterData myCharacterData, IPlayTurnGateway playTurnGateway)
    {
        this.myCharacterData = myCharacterData;
        this.playTurnGateway = playTurnGateway;
    }

    public void Execute()
    {
        playTurnGateway.PlayTurn(myCharacterData.myCharacterEnergy.Value)
            .Do(_ => myCharacterData.myCharacterEnergy.Value = myCharacterData.maxEnergy)
            .Subscribe();
    }

}
