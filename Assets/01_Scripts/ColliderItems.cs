using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderItems : MonoBehaviour
{
    public bool colliderEnter;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            colliderEnter = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            colliderEnter = false;
        }
    }
}
