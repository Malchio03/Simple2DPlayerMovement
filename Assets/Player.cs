using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed = 3.5f;
    [SerializeField] private float jumpForce = 8f;
    private float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleInput();
        HandleMovement();
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
}
