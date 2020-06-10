using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdBossScript : MonoBehaviour
{
  public int ThirdBossEnemyHealth;
  public GameObject ThirdBossEffect;
  public AudioClip sound;
  public GameObject PartitionOfBoss;

    void Update()
    {
      if (ThirdBossEnemyHealth <= 0) {
        Instantiate(ThirdBossEffect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        Instantiate(PartitionOfBoss,transform.position, Quaternion.identity);
        Instantiate(PartitionOfBoss,transform.position + new Vector3(0.4f,0,0), Quaternion.identity);
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      ThirdBossEnemyHealth -= damage;
    }
}
