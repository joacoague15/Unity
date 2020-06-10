using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fasterEnemyScript : MonoBehaviour
{
  public int fasterEnemyHealth;
  public GameObject effect;
  public AudioClip sound;

    void Update()
    {
      if (fasterEnemyHealth <= 0) {
        Instantiate(effect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(sound, transform.position);
        Destroy(gameObject);
      }
    }

    public void TakeDamage(int damage)
    {
      fasterEnemyHealth -= damage;
    }
}
