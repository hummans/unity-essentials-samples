using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

[CreateAssetMenu(fileName = "MyCharacter", menuName = "Scriptable/MyCharacter")]
public class MyCharacterData : ScriptableObject
{
    public StringReactiveProperty myCharacterName = new StringReactiveProperty();
    public IntReactiveProperty myCharacterEnergy = new IntReactiveProperty();
    public ISubject<MyCharacterMotion> OnMotion = new Subject<MyCharacterMotion>();
    public int maxEnergy;
    
}
