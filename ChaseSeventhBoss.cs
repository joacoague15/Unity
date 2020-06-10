using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseSeventhBoss : MonoBehaviour
{
  public float speed;
  public float stopDistance;
  public float retreatDistance;
  public GameObject ClashEffect;

  private Transform player;

  void Start() {
    player = GameObject.FindGameObjectWithTag("Player").transform;
  }

  void Update() {

  if (Vector2.Distance(transform.position, player.position) > stopDistance) {
    transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
  }
  else if (Vector2.Distance(transform.position, player.position) < stopDistance && Vector2.Distance(transform.position, player.position) > stopDistance){
    transform.position = this.transform.position;
  }
  else if (Vector2.Distance(transform.position, player.position) < retreatDistance) {
    transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
  }

}

void OnCollisionEnter2D(Collision2D col) {
  if (col.gameObject.name == "player") {
    Instantiate(ClashEffect, transform.position, Quaternion.identity);
    LifePlayerScript.LifePlayer -= 1;
    Destroy(gameObject);
  }
  }

}
