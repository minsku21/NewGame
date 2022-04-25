using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float runSpeed = 40;
    Vector2 horizontalMove;
    public float jumpForce = 500;
    bool IsGrounded;
    public Transform groundcheck;
    public LayerMask groundlayer;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove.x = Input.GetAxis("Horizontal") * runSpeed; 
        horizontalMove.y = rb.velocity.y;

        if (Input.GetKeyDown(KeyCode.Space)&&IsGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
        rb.velocity = horizontalMove;
    }
    void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundlayer);
    }
}
