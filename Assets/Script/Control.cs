using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the character's movement speed.
    
    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveInput * moveSpeed, rb2D.velocity.y);
        rb2D.velocity = movement;
    }
}