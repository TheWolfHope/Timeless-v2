using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
    public GameObject panelTiempo;
    public GameObject gameOverPanel;
    public GameObject panelPausa;
    public GameObject notas;
    public GameObject dialogo;
    public GameObject botonPausa;
    public GameObject temporizador;

    public int numeroEstaEscena;
    public int numeroMainMenu;

    private void Start()
    {
        Time.timeScale = 1f;
        panelTiempo.SetActive(true);
        gameOverPanel.SetActive(false);
        panelPausa.SetActive(false);
    }
    public void Reinicar()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("00_MainMenu");
    }

    public void GameOver()
    {
        panelTiempo.SetActive(false);
        gameOverPanel.SetActive(true);
        panelPausa.SetActive(false);
    }
    
    public void CerrarMenu()
    {
        panelPausa.SetActive(false);
    }

    public void ContinuarMenuDePausa()
    {
        Time.timeScale = 1f;
        panelPausa.SetActive(false);
    }

    public void SalirMenuDePausa()
    {
        SceneManager.LoadScene(numeroMainMenu);
    }

    public void AbrirMenuDePausa()
    {
        Time.timeScale = 0f;
        panelPausa.SetActive(true);
    }

    public void CerrarTodoParaQueSeaBienAlaHoraDeCuandoTeMaten()
    {
        notas.SetActive(false);
        dialogo.SetActive(false);
        botonPausa.SetActive(false);
        temporizador.SetActive(false);
    }
}
