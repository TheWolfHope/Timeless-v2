using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SpawnAsesinoScript : MonoBehaviour
{
    public GameObject asesino;
    public GameObject[] light2D;
    public TemporizadorScript temporizadorScript;
    public GameObject helper;
    public bool seSpaweno = false;
    public GameObject pauseButton;

    private void Update()
    {
        if (temporizadorScript.remainigngTime == 0)
        {
            helper.SetActive(false);
            pauseButton.SetActive(false);
            foreach(GameObject lit2D in light2D)
            {
                lit2D.SetActive(false);
            }
            if (!seSpaweno)
            {
                Instantiate(asesino, transform.position, transform.rotation);
                seSpaweno = true;
            }
        }
       
    }


}
