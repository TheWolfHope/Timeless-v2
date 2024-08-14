using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    float speedX, speedY;
    Rigidbody2D rb;
    public Vector2 moveDir;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");
        moveDir = new Vector2(speedX, speedY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = moveDir * moveSpeed;
    }
}
