using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
  //  public Slider staminaSlider;
    private bool IsCharacterAlive = true;
    private Vector3 lastMoveDirection;

    public float CharacterSpeed;
  //  public float sprintSpeed = 15f;
    public float normalSpeed = 5f;

    public Animator transition;
    public float transitionTime = 1f;
    public GameObject DeathEffect;

    private Rigidbody2D rb;

    private int direction;

    void Start() {
      rb = GetComponent<Rigidbody2D>();
      CharacterSpeed = 3f;
    }

   private void Update()
    {
      HandleMovement();
    }

    private void HandleMovement() {
      float moveX = 0f;
      float moveY = 0f;

        if (Input.GetKey(KeyCode.W)) {
          moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S)) {
          moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A)) {
          moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D)) {
          moveX = 1f;
        }

      if (IsCharacterAlive) {
        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        lastMoveDirection = moveDir;
        transform.position += new Vector3(moveX, moveY) * CharacterSpeed * Time.deltaTime;
      }
    }

    void FixedUpdate() {
      if (LifePlayerScript.LifePlayer <= 0) {
        IsCharacterAlive = false;
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        StartCoroutine(LoadLevel());
      }
    }

    IEnumerator LoadLevel() {
      transition.SetTrigger("Start");

      yield return new WaitForSeconds(transitionTime);

      SceneManager.LoadScene("LostMenu");
    }

}
