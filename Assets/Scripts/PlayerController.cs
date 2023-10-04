using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 4f; // Field
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        bool isKeyWasJustPressed = Input.GetKeyDown(KeyCode.Escape);
        if (...)
        {
            
        }

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 0);
        
        transform.Translate(0, 0, speed);
    }
}
