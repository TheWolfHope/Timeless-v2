using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Linternita : MonoBehaviour
{
    /* public Transform player;  */
    public bool flashOn = true;
    [SerializeField] Light2D flashlightOBJ;
    public Camera cam;
    void Awake()
    {
        flashlightOBJ = GetComponent<Light2D>();
    }

    void Update()
    {
        /* Vector3 movementDirection = player.GetComponent<Rigidbody2D>().velocity;
        if (movementDirection != Vector3.zero)
        {
            float angle = Mathf.Atan2(-movementDirection.x, movementDirection.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        } */
        Vector3 mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        float angleRad = MathF.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
        float angleDeg = (180 / MathF.PI) * angleRad - 90;

        transform.rotation = Quaternion.Euler(0f,0f,angleDeg);
        if(Input.GetKeyDown(KeyCode.F))
        {
            TurnFlashlight();          
        }
    }

    private void TurnFlashlight()
    {
        if(flashOn == true)
        {
            flashlightOBJ.intensity = 0f;
            flashOn = false;
        }
        else
        {
            flashlightOBJ.intensity = 0.2f;
            flashOn = true;
        }
        
    }
}
