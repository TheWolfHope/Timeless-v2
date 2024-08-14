using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDePaginas : MonoBehaviour
{int currentPage = 0;
public GameObject pagina1, pagina2;

public GameObject nextPageButton, previousPageButton;
   public void NextPage()
   {
        currentPage++;
       
   }
   public void PreviousPage()
   {
        currentPage--;   
   }
   public void RefreshSprite()
   {
        switch(currentPage)
        {
            case 0:
                pagina1.SetActive(true);
                pagina2.SetActive(false);
                previousPageButton.SetActive(false);
                nextPageButton.SetActive(true);
                break;
            case 1:
                pagina1.SetActive(false);
                pagina2.SetActive(true);
                nextPageButton.SetActive(false);
                previousPageButton.SetActive(true);
                break;
        }
   }
}
