using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerPista : MonoBehaviour
{
    public int clueNumber;
    public bool clueObtained = false;
    public GuardarDatosPistasYCargarlos dataPistas;
    public GameObject clue1UI, clue2UI, clue3UI, clue4UI, clue5UI;
    public GameObject paginablanca;
    void Awake()
    {
        ActualizarUIConLaData();
        GameObject gameManager = GameObject.Find("GameManager");
        if(gameManager != null)
        {
            dataPistas = gameManager.GetComponent<GuardarDatosPistasYCargarlos>();
        }
    }
    public void GiveClue()
    {
        switch(clueNumber)
        {
            case 0: 
                dataPistas.hasClue1 = 1; 
                PlayerPrefs.SetInt("HasClue1", 1);
                PlayerPrefs.Save();               
                clue1UI.SetActive(true);              
                break;              
            case 1:
                dataPistas.hasClue2 = 1;
                PlayerPrefs.SetInt("HasClue2", 1);
                PlayerPrefs.Save();
                clue2UI.SetActive(true);     
                break;
            case 2:
                dataPistas.hasClue3 = 1;
                PlayerPrefs.SetInt("HasClue3", 1);
                PlayerPrefs.Save();
                clue3UI.SetActive(true);       
                break;
            case 3:
                dataPistas.hasClue4 = 1;
                PlayerPrefs.SetInt("HasClue4", 1);
                PlayerPrefs.Save();
                clue4UI.SetActive(true); 
                break;
            case 4:
                dataPistas.hasClue5 = 1;
                PlayerPrefs.SetInt("HasClue5", 1);
                PlayerPrefs.Save();
                clue5UI.SetActive(true); 
                break;

            case 5:
                //Debug.Log("Llego a este punto");
                dataPistas.ResetearVariables();
                paginablanca.SetActive(true);
                break;
        }
        clueObtained = true;       
    }
    public void ActualizarUIConLaData()
    {
        if(dataPistas.hasClue1 == 1)
        {
            clue1UI.SetActive(true); 
        }
        else
        {
            clue1UI.SetActive(false);
        }
        if(dataPistas.hasClue2 == 1)
        {
            clue2UI.SetActive(true); 
        }
         else
        {
            clue2UI.SetActive(false);
        }
        if(dataPistas.hasClue3 == 1)
        {
            clue3UI.SetActive(true); 
        }
         else
        {
            clue3UI.SetActive(false);
        }
        if(dataPistas.hasClue4 == 1)
        {
            clue4UI.SetActive(true); 
        }
         else
        {
            clue4UI.SetActive(false);
        }
        if(dataPistas.hasClue5 == 1)
        {
            clue5UI.SetActive(true); 
        }
         else
        {
            clue5UI.SetActive(false);
        }
    }
}
