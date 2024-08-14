using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Linternita : MonoBehaviour
{
    public Transform player; // Asigna el transform del jugador en el inspector.
    public bool flashOn = true;
    [SerializeField] Light2D flashlightOBJ;
    void Awake()
    {
        flashlightOBJ = GetComponent<Light2D>();
    }

    void Update()
    {
        Vector3 movementDirection = player.GetComponent<Rigidbody2D>().velocity;
        if (movementDirection != Vector3.zero)
        {
            // Calcula el ángulo hacia el que rotar.
            float angle = Mathf.Atan2(-movementDirection.x, movementDirection.y) * Mathf.Rad2Deg;
            // Rota el objeto a ese ángulo.
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
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
