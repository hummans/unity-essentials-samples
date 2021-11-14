using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using UniRx;

public class CmdPlayTurn : MonoBehaviour
{
    private SCharacterData characterData;
    private IPlayTurnGateway gateway;
    private IMetricsTagger metricsTagger;

    public CmdPlayTurn(SCharacterData characterData, IPlayTurnGateway gateway, IMetricsTagger metricsTagger)
    {
        this.characterData = characterData;
        this.gateway = gateway;
        this.metricsTagger = metricsTagger;
    }
    
    public void Execute()
    {
        gateway.PlayTurn(characterData.energy.Value)
            .Do(_ => metricsTagger.TagEvent(metric: "Sent Energy"))
            .Do(_ => characterData.energy.Value = 100)
            .Subscribe();
    }
}
