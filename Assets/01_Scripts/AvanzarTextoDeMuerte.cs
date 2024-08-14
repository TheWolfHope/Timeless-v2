using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class AvanzarTextoDeMuerte : MonoBehaviour
{
    public ScriptDialogoDeMuerte dialogoDeMuerte;
    void Update()
    {       
        if(dialogoDeMuerte.dialogueText.text == dialogoDeMuerte.dialogueLines[dialogoDeMuerte.lineIndex])
            {
                if(Input.GetMouseButtonDown(0))
                {
                    dialogoDeMuerte.NextDialogueLine();
                }
            }
                
    }
    
}
