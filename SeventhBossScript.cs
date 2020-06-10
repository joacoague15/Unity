using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeventhBossScript : MonoBehaviour
{
  public int SeventhBossEnemyHealth;
  public GameObject SeventhBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (SeventhBossEnemyHealth <= 0) {
        Instantiate(SeventhBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        StartCoroutine(startTransition());
      }
    }

    public void TakeDamage(int damage)
    {
      SeventhBossEnemyHealth -= damage;
    }

    IEnumerator startTransition() {
      LifePlayerScript.LifePlayer += 10000;

      yield return new WaitForSeconds(3);

      SceneManager.LoadScene("EndScene");
    }

}
