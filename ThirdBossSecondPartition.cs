using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdBossSecondPartition : MonoBehaviour
{
  public int ThirdBossSecondPartitionHealth;
  public GameObject ThirdBossEffect;
  public AudioClip sound;

    void Update()
    {
      if (ThirdBossSecondPartitionHealth <= 0) {
        Instantiate(ThirdBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        TimeForBossScript.ThirdBossIsDead = true;
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      ThirdBossSecondPartitionHealth -= damage;
    }
}
