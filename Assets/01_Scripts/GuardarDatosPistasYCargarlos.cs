using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarDatosPistasYCargarlos : MonoBehaviour
{
    public ObtenerPista[] obtenerPista;
    public int variablePrueba; 
    public int hasClue1;
    public int hasClue2;
    public int hasClue3;
    public int hasClue4;
    public int hasClue5;

    public int win;

    private void Awake()
    {
        hasClue1 = PlayerPrefs.GetInt("HasClue1", 0);
        hasClue2 = PlayerPrefs.GetInt("HasClue2", 0);
        hasClue3 = PlayerPrefs.GetInt("HasClue3", 0);
        hasClue4 = PlayerPrefs.GetInt("HasClue4", 0);
        hasClue5 = PlayerPrefs.GetInt("HasClue5", 0);

        win = PlayerPrefs.GetInt("win", 0);
    }

    private void Update()
    {           
        if (hasClue1 == 1 && hasClue2 == 1 && hasClue3 == 1 && hasClue4 == 1 && hasClue5 == 1)
        {
            win = 1;
            PlayerPrefs.SetInt("win", 1);
            PlayerPrefs.Save();
        }
    }

    public void ResetearVariables() 
        {
        hasClue1 = 0; 
        PlayerPrefs.SetInt("HasClue1", 0);


        hasClue2 = 0;
        PlayerPrefs.SetInt("HasClue2", 0);


        hasClue3 = 0;
        PlayerPrefs.SetInt("HasClue3", 0);


        hasClue4 = 0;
        PlayerPrefs.SetInt("HasClue4", 0);


        hasClue5 = 0;
        PlayerPrefs.SetInt("HasClue5", 0);
        PlayerPrefs.Save();

        win = 0;

        foreach (ObtenerPista obtPistas in obtenerPista)
        {
            obtPistas.ActualizarUIConLaData();
            obtPistas.clueObtained = false;
        }
    } 

}
