using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeventhBossProjectileScript : MonoBehaviour
{
  public float speed;

  private Transform player;
  private Vector2 target;
  public GameObject SeventhProjectileEffect;
  public int SeventhBossProjectileHealth;

  void Start() {
    player = GameObject.FindGameObjectWithTag("Player").transform;
    target = new Vector2(player.position.x, player.position.y);
  }

  void Update() {
      transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

      if (SeventhBossProjectileHealth <= 0) {
        Instantiate(SeventhProjectileEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
      }

  }

  void OnTriggerEnter2D(Collider2D col) {
    if (col.CompareTag("Player")) {
      LifePlayerScript.LifePlayer -= 1;
      DestroyProjectile();
    }
  }

  void DestroyProjectile() {
    Destroy(gameObject);
  }

  public void TakeDamage(int damage)
  {
    SeventhBossProjectileHealth -= damage;
  }

}
