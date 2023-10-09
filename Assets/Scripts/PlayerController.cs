using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 4f; // Field
    public float jumpForce = 300;
    public float jumpSpin = 2;
    public float fallGravity = -1f;
    
    private const float fallTolerance = -.1f;
    
    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidBody.velocity;
        if (velocity.y < fallTolerance)
        {
            rigidBody.AddForce(0, fallGravity, 0);
        }

        velocity.z = speed;
        rigidBody.velocity = velocity;
    }

    void Update()
    {
        if(Input.GetButton("Jump") && IsTouchingGround())
        {
            Jump();
        }
    }

    void Jump()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidBody.velocity;
        velocity.y = jumpForce;
        rigidBody.velocity = velocity;
        rigidBody.angularVelocity = new Vector3(x: jumpSpin, 0, 0);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
