using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocity;
    public float speed;

 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")));
        velocity = moveInput * speed;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
}
