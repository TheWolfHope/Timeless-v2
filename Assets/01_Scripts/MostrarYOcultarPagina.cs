using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarYOcultarPagina : MonoBehaviour
{
    bool isMenuOpen = false;
    public GameObject menuDePistas;
    public GameObject openMenuButton;
    public PlayerMovement playerMovement;
    public Animator clueAnim;

    public void OpenMenu()
    {
        if(isMenuOpen == false)
        {
            isMenuOpen = true;
            menuDePistas.SetActive(true);
            openMenuButton.SetActive(false);
            playerMovement.moveSpeed = 0f;
        }
        else{
            return;
        }
    }
    public void CloseMenu(){
        if(isMenuOpen == true){
            isMenuOpen = false;
            menuDePistas.SetActive(false);
            openMenuButton.SetActive(true);
            playerMovement.moveSpeed = 6f;
            clueAnim.SetTrigger("Normal");
        }
    }
}
