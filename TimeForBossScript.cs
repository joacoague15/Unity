using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeForBossScript : MonoBehaviour
{
    public GameObject FirstBoss;
    public GameObject SecondBoss;
    public GameObject ThirdBoss;
    public GameObject FourthBoss;
    public GameObject FifthBoss;
    public GameObject SixthBoss;
    public GameObject SeventhBoss;

    private float TimeInGame;
    private bool FirstBossIsHere;
    private bool SecondBossIsHere;
    private bool ThirdBossIsHere;
    private bool FourthBossIsHere;
    private bool FifthBossIsHere;
    private bool SixthBossIsHere;
    private bool SeventhBossIsHere;

    static public bool FirstBossIsDead;
    static public bool SecondBossIsDead;
    static public bool ThirdBossIsDead;
    static public bool FourthBossIsDead;
    static public bool FifthBossIsDead;
    static public bool SixthBossIsDead;
    static public bool SeventhBossIsDead;

    void Start()
    {
      FirstBossIsHere = false;
      SecondBossIsHere = false;
      ThirdBossIsHere = false;
      FourthBossIsHere = false;
      FifthBossIsHere = false;
      SixthBossIsHere = false;
      SeventhBossIsHere = false;
      SeventhBossIsHere = false;

      FirstBossIsDead = false;
      SecondBossIsDead = false;
      ThirdBossIsDead = false;
      FourthBossIsDead = false;
      FifthBossIsDead = false;
      SixthBossIsDead = false;
      SeventhBossIsDead = false;

    }

    void Update()
    {
      if (!FirstBossIsHere) {
        FirstBossAppear();
      }

      if (!SecondBossIsHere && FirstBossIsDead == true) {
        SecondBossAppear();
      }
      if (!ThirdBossIsHere && SecondBossIsDead == true) {
        ThirdBossAppear();
      }
      if (!FourthBossIsHere && ThirdBossIsDead == true) {
        FourthBossAppear();
      }
      if (!FifthBossIsHere && FourthBossIsDead == true) {
        FifthBossAppear();
      }
      if (!SixthBossIsHere && FifthBossIsDead == true) {
        SixthBossAppear();
      }
      if (!SeventhBossIsHere && SixthBossIsDead == true) {
        SeventhBossAppear();
      }

    }


    void FirstBossAppear() {
      Instantiate(FirstBoss, new Vector3(Random.Range(-11,11), 10, 3), Quaternion.identity);
      FirstBossIsHere = true;
    }

    void SecondBossAppear() {
      Instantiate(SecondBoss, new Vector3(Random.Range(-11,11), -8, 3), Quaternion.identity);
      SecondBossIsHere = true;
    }

    void ThirdBossAppear() {
        Instantiate(ThirdBoss, new Vector3(-15, Random.Range(-6,6), 3), Quaternion.identity);
        ThirdBossIsHere = true;
    }

    void FourthBossAppear() {
        Instantiate(FourthBoss, new Vector3(-14, Random.Range(-6,6), 3), Quaternion.identity);
        Instantiate(FourthBoss, new Vector3(Random.Range(-6,6), 9, 3), Quaternion.identity);
        Instantiate(FourthBoss, new Vector3(Random.Range(-6,6), -9, 3), Quaternion.identity);
        FourthBossIsHere = true;
      }

      void FifthBossAppear() {
        Instantiate(FifthBoss, new Vector3(Random.Range(-8,8), -11, 3), Quaternion.identity);
        FifthBossIsHere = true;
      }

      void SixthBossAppear() {
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        Instantiate(SixthBoss, new Vector3(14, Random.Range(-7,7), 3), Quaternion.identity);
        SixthBossIsHere = true;
      }

      void SeventhBossAppear() {
        StartCoroutine(waitForBossCoroutine());
        SeventhBossIsHere = true;
      }

      private IEnumerator waitForBossCoroutine() {
        yield return new WaitForSeconds(10);
        Instantiate(SeventhBoss, new Vector3(30, 10, 3), Quaternion.identity);
      }

}
