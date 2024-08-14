using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarDatosPistasYCargarlos : MonoBehaviour
{
    public ObtenerPista[] obtenerPista;
    public bool variablePrueba = true; 
    public bool hasClue1;
    public bool hasClue2;
    public bool hasClue3;
    public bool hasClue4;
    public bool hasClue5;

    public bool win = false;

    private void Start()
    {
        hasClue1 = PlayerPrefs.GetInt("HasClue1", 0) == 1 ? true : false;
        hasClue2 = PlayerPrefs.GetInt("HasClue2", 0) == 1 ? true : false;
        hasClue3 = PlayerPrefs.GetInt("HasClue3", 0) == 1 ? true : false;
        hasClue4 = PlayerPrefs.GetInt("HasClue4", 0) == 1 ? true : false;
        hasClue5 = PlayerPrefs.GetInt("HasClue5", 0) == 1 ? true : false;

        win = PlayerPrefs.GetInt("win", 0) == 1 ? true : false;
    }

    private void Update()
    {      
      

        if (hasClue1 && hasClue2 && hasClue3 && hasClue4 && hasClue5)
        {
            win = true;
            PlayerPrefs.SetInt("win", 1);
            PlayerPrefs.Save();
        }
    }

    public void ResetearVariables() 
        {
        hasClue1 = false; // Solo para En caso de querer reiniciar la variable HasClue1 al presionar "R".
        PlayerPrefs.SetInt("HasClue1", 0);
        PlayerPrefs.Save();

        hasClue2 = false;
        PlayerPrefs.SetInt("HasClue2", 0);
        PlayerPrefs.Save();

        hasClue3 = false;
        PlayerPrefs.SetInt("HasClue3", 0);
        PlayerPrefs.Save();

        hasClue4 = false;
        PlayerPrefs.SetInt("HasClue4", 0);
        PlayerPrefs.Save();

        hasClue5 = false;
        PlayerPrefs.SetInt("HasClue5", 0);
        PlayerPrefs.Save();

        win = false;

        foreach (ObtenerPista obtPistas in obtenerPista)
        {
            obtPistas.ActualizarUIConLaData();
            obtPistas.clueObtained = false;
        }
    } 

}
