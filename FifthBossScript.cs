using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthBossScript : MonoBehaviour
{
  public int FifthBossEnemyHealth;
  public GameObject FifthBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (FifthBossEnemyHealth <= 0) {
        Instantiate(FifthBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.FifthBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      FifthBossEnemyHealth -= damage;
    }
}
