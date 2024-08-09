using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float horizontal;
    [SerializeField] float speed = 8f;
    [SerializeField] float jumpinPower = 16f;
    [SerializeField] float fallingPowerFactor = 0.5f;
    private bool isFacingRight = true;
    public bool isGrounded = true;
    [SerializeField] Animator anim;

    //[SerializeField] private LayerMask groundLayer;
    //[SerializeField] private Transform groundCheck;
    [SerializeField] private Rigidbody2D body;
    
    void Update()
    {    
        

    }   

    private void FixedUpdate() 
    {
        horizontal = Input.GetAxisRaw("Horizontal");  
        body.velocity = new Vector2(horizontal*speed,body.velocity.y);   
        
        Flip();  
        Jump();
        RotationLimit();   
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x , jumpinPower);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    
    /*
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    */

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void RotationLimit()
    {
        float currentRotation = transform.eulerAngles.z;

        if (currentRotation > 180)
        {
            currentRotation -= 360;
        }

        currentRotation = Mathf.Clamp(currentRotation, -25, 25);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentRotation);

        
    }
}
