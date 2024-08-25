using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
   
    public void NoSePuedeMover()
    {
        playerMovement.moveSpeed = 0;
    }
    public void SePuedeMover()
    {
        playerMovement.moveSpeed = 6;
    }
}
