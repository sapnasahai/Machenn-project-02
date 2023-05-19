using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickAnimation : MonoBehaviour
{
    private Animator animator;

    private void OnMouseDown1()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        AnimationClip clip = animator.runtimeAnimatorController.animationClips[0];
        clip.wrapMode = WrapMode.Once;
        animator.Play(clip.name);
    }
}
