using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongerEnemyScript : MonoBehaviour
{
  public int strongerEnemyHealth;
  public GameObject effect;
  public AudioClip sound;

    void Update()
    {
      if (strongerEnemyHealth <= 0) {
        Instantiate(effect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      strongerEnemyHealth -= damage;
    }
}
