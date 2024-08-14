using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] ScriptDialogo diallScript;
    [SerializeField] ColliderItems collItem;
    public bool hasClicked;
    public void OnPointerClick(PointerEventData eventData)
    {   
            if(collItem.colliderEnter == true)
            {
                if(hasClicked == false)
                {
                    hasClicked = true;
                    if (diallScript.didDialogueStart == false)
                    {
                    diallScript.StartDialogue();
                    }            
                    else
                    {
                    diallScript.StopAllCoroutines();
                    diallScript.dialogueText.text = diallScript.dialogueLines[diallScript.lineIndex];
                    diallScript.lineIndex = 0;
                    }
                }
                else
                {
                    return;
                }
                
            }                       
    }
    void Update()
    {
        
        if(diallScript.dialogueText.text == diallScript.dialogueLines[diallScript.lineIndex])
            {
                if(Input.GetMouseButtonDown(0))
                {
                    diallScript.NextDialogueLine();
                }
            }
                
    }
    
}
