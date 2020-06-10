using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SixthBossScript : MonoBehaviour
{
  public int SixthBossEnemyHealth;
  public GameObject SixthBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (SixthBossEnemyHealth <= 0) {
        Instantiate(SixthBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.SixthBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      SixthBossEnemyHealth -= damage;
    }
}
