using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdBossFirstPartition : MonoBehaviour
{
  public int ThirdBossFirstPartitionHealth;
  public GameObject ThirdBossEffect;
  public AudioClip sound;
  public GameObject SecondPartitionOfBoss;

    void Update()
    {
      if (ThirdBossFirstPartitionHealth <= 0) {
        Instantiate(ThirdBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        Instantiate(SecondPartitionOfBoss,transform.position, Quaternion.identity);
        Instantiate(SecondPartitionOfBoss,transform.position + new Vector3(0.2f,0f,0f), Quaternion.identity);
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      ThirdBossFirstPartitionHealth -= damage;
    }
}
