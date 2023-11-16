using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private Collider2D characterCollider;

    private bool isGrounded;
    public LayerMask groundLayer;
    public float jumpForce = 10f;

    public float moveSpeed = 5f;
    public bool canButton;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        characterCollider = GetComponent<Collider2D>();
        canButton = false;
    }


    void Update()
    {
        MoveCharacter();
        HandleJump();
        CheckGround();
    }

    void MoveCharacter()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput, 0);
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        if (horizontalInput > 0)
        {
            // Saða hareket
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("isWalking", true);
        }
        else if (horizontalInput < 0)
        {
            // Sola hareket
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("isWalking", true);
        }
        else
        { 
            animator.SetBool("isWalking", false); 
        }
    }

    void HandleJump()
    {
        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W)) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void CheckGround()
    {
        float raycastLength = 0.1f;
        float colliderHalfHeight = characterCollider.bounds.extents.y;

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastLength + colliderHalfHeight, groundLayer);
    }
}
