using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class characterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private float horizontal;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); 
    }

    public void Move(InputAction.CallbackContext ctx){
        horizontal = ctx.ReadValue<Vector2>().x;
    }
}
