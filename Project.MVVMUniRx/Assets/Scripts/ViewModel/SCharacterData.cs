using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

[CreateAssetMenu(fileName = "New Character Data", menuName = "Scriptable/Character")]
public class SCharacterData : ScriptableObject
{
    public StringReactiveProperty characterName = new StringReactiveProperty();
    public IntReactiveProperty energy = new IntReactiveProperty();
    public ISubject<SCharacterMotion> OnMotion = new Subject<SCharacterMotion>();
}
