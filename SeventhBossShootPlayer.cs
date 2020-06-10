using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeventhBossShootPlayer : MonoBehaviour
{
  public float startTimeBetweenShots;
  public GameObject Projectile;

  private float timeBetweenShots;

    void Start()
    {
      timeBetweenShots = startTimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
      if (timeBetweenShots <= 0) {
        //Shoot Enemy Projectile
        Instantiate(Projectile, transform.position, Quaternion.identity);
        timeBetweenShots = startTimeBetweenShots;
      }
      else {
        timeBetweenShots -= Time.deltaTime;
      }
    }
}
