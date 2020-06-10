using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
  public float offset;

    public GameObject projectile;
    public Transform shotPoint;
    public float StartTimeAgain = 0f;
    public float time;
    static public float timeBetweenProjectiles = 0.2f;

    void Start() {
      time = 0f;
    }

    void Update()
    {
      time += Time.deltaTime;
      Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
      float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (Input.GetButton("Fire1")) {
            if (time >= timeBetweenProjectiles) {
              Instantiate(projectile, shotPoint.position, transform.rotation);
              time = StartTimeAgain;
            }
          }
    }
  }
