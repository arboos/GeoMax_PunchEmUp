using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [Range(1, 5)] public float walkXSpeed;
    [Range(1, 5)] public float walkZSpeed;

    private float rotationY = 90f; 
    private float rotationSpeed = 15f; 
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
