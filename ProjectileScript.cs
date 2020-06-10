using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask WhatIsSolid;
    public GameObject effect;
    public AudioClip sound;

    void Start() {
      Invoke("DestroyProjectile", lifeTime);
    }

    void Update ()
    {
      RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, WhatIsSolid);
      if (hitInfo.collider != null) {
        if (hitInfo.collider.CompareTag("Enemy")) {
          hitInfo.collider.GetComponent<BasicEnemy>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("FasterEnemy")) {
          hitInfo.collider.GetComponent<fasterEnemyScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("StrongerEnemy")) {
          hitInfo.collider.GetComponent<strongerEnemyScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("FirstBoss")) {
          hitInfo.collider.GetComponent<FirstBossEnemyScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("SecondBoss")) {
          hitInfo.collider.GetComponent<SecondBossEnemyScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("ThirdBoss")) {
          hitInfo.collider.GetComponent<ThirdBossScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("FourthBoss")) {
          hitInfo.collider.GetComponent<FourthBossScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("FifthBoss")) {
          hitInfo.collider.GetComponent<FifthBossScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("SixthBoss")) {
          hitInfo.collider.GetComponent<SixthBossScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("SeventhBoss")) {
          hitInfo.collider.GetComponent<SeventhBossScript>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("FirstPartitionBoss")) {
          hitInfo.collider.GetComponent<ThirdBossFirstPartition>().TakeDamage(damage);
          MakeSound();
        }else if (hitInfo.collider.CompareTag("SecondPartitionBoss")) {
          hitInfo.collider.GetComponent<ThirdBossSecondPartition>().TakeDamage(damage);
          MakeSound();
        }
        else if (hitInfo.collider.CompareTag("SeventhBossProjectile")) {
          hitInfo.collider.GetComponent<SeventhBossProjectileScript>().TakeDamage(damage);
          MakeSound();
        }
        DestroyProjectile();
      }
      transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile() {
      Instantiate(effect, transform.position, Quaternion.identity);
      Destroy(gameObject);
    }

    void MakeSound() {
      AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
