using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float moveForce = 100;
    [SerializeField] float jumpForce = 100;
    [SerializeField] Rigidbody2D body;
    
    void Update()
    {    
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(Vector2.right * moveForce);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(Vector2.left * moveForce);    
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * jumpForce);
        }

    }   
}
