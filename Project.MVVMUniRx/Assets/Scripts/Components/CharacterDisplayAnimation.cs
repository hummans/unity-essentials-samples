using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CharacterDisplayAnimation : MonoBehaviour
{
    public Animator animator;
    public SCharacterData characterData;

    void Start()
    {
        characterData.OnMotion
            .Subscribe(AnimateMotion)
            .AddTo(this);
    }

    private void AnimateMotion(SCharacterMotion motion)
    {
        animator.SetTrigger(motion.motionName);
    }
}
