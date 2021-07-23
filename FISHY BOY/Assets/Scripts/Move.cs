using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    float xInput, yInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveInput();
    }

    private void FixedUpdate()
    {
        Movement();   
    }

    void MoveInput()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    void Movement()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * speed);
    }

}
