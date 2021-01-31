using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState {
    walk,
    interact
}

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public PlayerState currentState;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

    void Start() {
      currentState = PlayerState.walk;
    }

    // Update is called once per frame
    void Update() {
      if(currentState == PlayerState.interact) {
        return;
      }
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");

      animator.SetFloat("Horizontal", movement.x);
      animator.SetFloat("Vertical", movement.y);
      animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
