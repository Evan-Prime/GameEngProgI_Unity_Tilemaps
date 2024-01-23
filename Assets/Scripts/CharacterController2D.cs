using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5;

    [SerializeField] private Rigidbody2D rb;
    
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);
    }
}
