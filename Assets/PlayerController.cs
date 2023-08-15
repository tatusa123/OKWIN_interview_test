using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed, jumpForce;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;
    Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Moving();
        Jump();
    }
    void Moving()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && GroundCheck())
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
        }
        if (Input.GetButtonUp("Jump") && GroundCheck())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * 0.5f);
        }
    }
    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
