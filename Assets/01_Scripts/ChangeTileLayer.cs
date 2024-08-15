using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeTileLayer : MonoBehaviour
{
    public GameObject botTileLayer;
    public GameObject topTileLayer;
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            topTileLayer.SetActive(true);
            botTileLayer.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
       if(other.tag == "Player")
        {
            topTileLayer.SetActive(false);
            botTileLayer.SetActive(true);
        }
    }
}
