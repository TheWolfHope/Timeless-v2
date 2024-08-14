using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClickAyudante : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] ScriptAyudante scriptAyudante;
    [SerializeField] ColliderItems collItem;
    public bool hasClicked;
    public void OnPointerClick(PointerEventData eventData)
    {   
            if(collItem.colliderEnter == true)
            {
                if(hasClicked == false)
                {
                    hasClicked = true;
                    if (scriptAyudante.didDialogueStart == false)
                    {
                    scriptAyudante.StartDialogue();
                    }            
                    else
                    {
                    scriptAyudante.StopAllCoroutines();
                    scriptAyudante.dialogueText.text = scriptAyudante.dialogueLines[scriptAyudante.lineIndex];
                    scriptAyudante.lineIndex = 0;
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
        if(scriptAyudante.dialogueText.text == scriptAyudante.dialogueLines[scriptAyudante.lineIndex])
            {
                if(Input.GetMouseButtonDown(0))
                {
                    scriptAyudante.NextDialogueLine();
                }
            }
                
    }
    
}
