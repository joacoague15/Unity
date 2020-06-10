using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AgainButton : MonoBehaviour
{
    public void WhenPressPlayButton()
    {
      LifePlayerScript.LifePlayer = 1;
      SceneManager.LoadScene("mainScene");
    }
}
