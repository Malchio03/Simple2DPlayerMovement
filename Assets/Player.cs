using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed = 3.5f;
    [SerializeField] private float jumpForce = 8f;
    private float xInput;

    private bool facingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        HandleInput();
        HandleMovement();
        HandleAnimations();
        HandleFlip();
    }

    private void HandleAnimations()
    {
        bool isMoving = rb.linearVelocity.x != 0;

        anim.SetBool("isMoving", isMoving);
    }

    private void HandleInput()
    {
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    private void HandleMovement()
    {
        // update the player's horizontal velocity based on input
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    private void HandleFlip()
    {
        if (rb.linearVelocity.x > 0 && facingRight == false)
        {
            Flip();
        }
        else if (rb.linearVelocity.x < 0 && facingRight == true)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        facingRight = !facingRight;
    }
}
