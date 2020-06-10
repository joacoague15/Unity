using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{
  SpriteRenderer spriteRenderer;

  public AudioClip sound;

  public int health;
  public GameObject effect;

  void Start() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  void Update() {
    if (health <= 0) {
      Instantiate(effect, transform.position, Quaternion.identity);
      AudioSource.PlayClipAtPoint(sound, transform.position);
      Destroy(gameObject);
    }
  }

    public void TakeDamage(int damage)
    {
      health -= damage;
    }
}
