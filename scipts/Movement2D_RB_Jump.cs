using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D_RB_Jump : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 10f;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        float distanceToGround = GetComponent<Collider2D>().bounds.extents.y;
        return Physics2D.Raycast(transform.position, Vector2.down, distanceToGround + 0.1f);
    }
}
