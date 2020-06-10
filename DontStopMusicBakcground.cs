using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontStopMusicBakcground : MonoBehaviour
{
  private static DontStopMusicBakcground instance;

  void Awake() {
    if (instance == null) {
      instance = this;
      DontDestroyOnLoad(instance);
    }
    else {
      Destroy(gameObject);
    }
  }

}
