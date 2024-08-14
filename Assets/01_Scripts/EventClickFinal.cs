using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClickFinal : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] ScriptDialogoFinal scriptDialFinal;
    [SerializeField] ColliderItems collItem;
    public bool hasClicked;
    public void OnPointerClick(PointerEventData eventData)
    {   
            if(collItem.colliderEnter == true)
            {
                if(hasClicked == false)
                {
                    hasClicked = true;
                    if (scriptDialFinal.didDialogueStart == false)
                    {
                    scriptDialFinal.StartDialogue();
                    }            
                    else
                    {
                    scriptDialFinal.StopAllCoroutines();
                    scriptDialFinal.dialogueText.text = scriptDialFinal.dialogueLines[scriptDialFinal.lineIndex];
                    scriptDialFinal.lineIndex = 0;
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
        if(scriptDialFinal.dialogueText.text == scriptDialFinal.dialogueLines[scriptDialFinal.lineIndex])
            {
                if(Input.GetMouseButtonDown(0))
                {
                    scriptDialFinal.NextDialogueLine();
                }
            }
                
    }
    
}
