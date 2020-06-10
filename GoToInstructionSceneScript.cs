using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class GoToInstructionSceneScript : MonoBehaviour
{
  public void goToInstructions() {
    SceneManager.LoadScene("IntructionsTutorial");
  }

}
