using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class MyCharacterAnimationDisplay : MonoBehaviour
{
    public Animator animator;
    public MyCharacterData myCharacterData;

    void Start()
    {
        myCharacterData.OnMotion
            .Subscribe(OnMotion)
            .AddTo(this);
    }
    
    private void OnMotion(MyCharacterMotion myCharacterMotion)
    {
        animator.SetTrigger(myCharacterMotion.motionName);
    }
}
