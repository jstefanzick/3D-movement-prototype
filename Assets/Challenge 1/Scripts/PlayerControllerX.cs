﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed = 80;
    public float verticalInput;
    public float horizontalInput;
    public float spaceInput;
    public float turnInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        spaceInput = Input.GetAxis("Jump");
        turnInput = Input.GetAxis("Turn");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * spaceInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * turnInput);

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);

        if(spaceInput == 0){
            transform.Translate(Vector3.down * Time.deltaTime * 10);
        }
    }
}
