﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void OnMove(InputValue movemntValue)
    {
        Vector2 movementVector = movemntValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y; 
    }
   
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed); 
    }
}
