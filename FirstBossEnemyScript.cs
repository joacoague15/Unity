using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstBossEnemyScript : MonoBehaviour
{
  public int FirstBossEnemyHealth;
  public GameObject FirstBossEffect;
  public AudioClip sound;
  public GameObject player;

    void Update()
    {
      if (FirstBossEnemyHealth <= 0) {
        Instantiate(FirstBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.FirstBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      FirstBossEnemyHealth -= damage;
    }
}
