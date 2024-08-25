using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TurnLights : MonoBehaviour
{
    public Light2D[] lightToTurn;
    public bool isTurnOn = false;
    void OnTriggerStay2D (Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!isTurnOn)
            {
                isTurnOn = true;
                foreach(Light2D lights in lightToTurn)
                {
                    lights.intensity = 1;
                }
            }           
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(isTurnOn)
            {
                isTurnOn = false;
                foreach(Light2D lights in lightToTurn)
                {
                    lights.intensity = 0;
                }
            }
    }
}
