using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickAnimation1 : MonoBehaviour
{
    public List<AnimationClip> clips;

    private Animation animation;

    private void Start()
    {
        animation = GetComponent<Animation>();
        foreach (AnimationClip clip in clips)
        {
            animation.AddClip(clip, clip.name);
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(PlayAnimations());
    }

    private IEnumerator PlayAnimations()
    {
        foreach (AnimationClip clip in clips)
        {
            animation.Play(clip.name);
            yield return new WaitForSeconds(clip.length);
        }
    }
}
