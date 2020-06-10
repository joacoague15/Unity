using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectileScript : MonoBehaviour
{
  public float speed;
  public GameObject BossProjectileEffect;

  private Transform player;
  private Vector2 target;

  void Start() {
    player = GameObject.FindGameObjectWithTag("Player").transform;
    target = new Vector2(player.position.x, player.position.y);
  }

  void Update() {
      transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

      if (transform.position.x == target.x && transform.position.y == target.y) {
        DestroyProjectile();
      }
  }

  void OnTriggerEnter2D(Collider2D col) {
    if (col.CompareTag("Player")) {
      LifePlayerScript.LifePlayer -= 1;
      DestroyProjectile();
    }
  }

  void DestroyProjectile() {
    Instantiate(BossProjectileEffect, transform.position, Quaternion.identity);
    Destroy(gameObject);
  }

}
