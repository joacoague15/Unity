using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationOfTitle : MonoBehaviour
{
  private Animation animation;
  private float waitTime;

void Start() {
  animation = GetComponent<Animation>();
  waitTime = 4f;
  InvokeRepeating ("PlayAnim", 4f, waitTime);
}

void PlayAnim() {
  animation.Play("AnimationOfTitle");
}
}
