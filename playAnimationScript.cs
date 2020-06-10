using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playAnimationScript : MonoBehaviour
{
  private Animation animation;
  private float waitTime;

  void Start() {
    animation = GetComponent<Animation>();
    waitTime = 12f;
    InvokeRepeating ("PlayAnim", 12f, waitTime);
  }

  void PlayAnim() {
    animation.Play("AnimationOfPlayButton");
  }





}
