using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float runSpeed = 40;
    Vector2 horizontalMove;
    public float jumpForce = 500;


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

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = horizontalMove;
    }
}
