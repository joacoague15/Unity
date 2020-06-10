using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondBossEnemyScript : MonoBehaviour
{
  public int SecondBossEnemyHealth;
  public GameObject SecondBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (SecondBossEnemyHealth <= 0) {
        Instantiate(SecondBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.SecondBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      SecondBossEnemyHealth -= damage;
    }
}
