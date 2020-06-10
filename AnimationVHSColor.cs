using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationVHSColor : MonoBehaviour
{
  private Animation animation;
  private float waitTime;

  void Start() {
    animation = GetComponent<Animation>();
    waitTime = Random.Range(3f, 7f);
    InvokeRepeating ("PlayAnim", 5f, waitTime);
  }

  void PlayAnim() {
    animation.Play("VHSColor_Animation");
  }





}
