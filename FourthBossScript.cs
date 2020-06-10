using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FourthBossScript : MonoBehaviour
{
  public int FourthBossEnemyHealth;
  public GameObject FourthBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (FourthBossEnemyHealth <= 0) {
        Instantiate(FourthBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.FourthBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      FourthBossEnemyHealth -= damage;
    }

}
