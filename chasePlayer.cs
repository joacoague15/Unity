using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chasePlayer : MonoBehaviour
{
  public float speed;
  public GameObject ClashEffect;

  private Transform target;

    void Start() {
      target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
      transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.name == "player") {
        Instantiate(ClashEffect, transform.position, Quaternion.identity);
        LifePlayerScript.LifePlayer -= 1;
        Destroy(gameObject);
      }
      }
}
