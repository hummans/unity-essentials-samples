using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Data", menuName = "Scriptable/Command Factory/Character")]
public class CharacterFactoryCmd : ScriptableObject
{
    public CmdPerfomMotion PerfomMotion(SCharacterData characterData, SCharacterMotion motion)
    {
        return new CmdPerfomMotion(characterData, motion);
    }
    public CmdPlayTurn PlayTurn(SCharacterData characterData)
    {
        return new CmdPlayTurn(characterData, new PlayGateway(), new MetricsTagger());
    }
}
