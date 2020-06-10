using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTutorialScript : MonoBehaviour
{
  private Animation animation;
  private float waitTime;

void Start() {
  animation = GetComponent<Animation>();
  waitTime = 8f;
  InvokeRepeating ("PlayAnim", 6f, waitTime);
}

void PlayAnim() {
  animation.Play("AnimationOfTutorial");
}

}
