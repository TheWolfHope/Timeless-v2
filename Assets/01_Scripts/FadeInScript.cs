using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInScript : MonoBehaviour
{
    public Animator animator;
    public GuardarDatosPistasYCargarlos guardardatosypitasycargalos;
    public int numeroScenaFinal;
    public GameObject paginablanca;


    void Start()
    {
       
        
        paginablanca.SetActive(false);

  

    }

    private void Update()
    {
        if (guardardatosypitasycargalos.win)
        {
            
            
                paginablanca.SetActive(true);
                guardardatosypitasycargalos.win = false;
          
                PlayerPrefs.SetInt("win", 0);
                PlayerPrefs.Save();
            
          
        }
    }

   


    public void Ganaste()
    {
     
        
        SceneManager.LoadScene(numeroScenaFinal);
        
      

    }


}
