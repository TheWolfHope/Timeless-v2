using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Microsoft.Unity.VisualStudio.Editor;

public class ScriptAyudante : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    public Animator uiSecondImage;
    private float typingTime = 0.03f;
    public bool didDialogueStart;
    public int lineIndex;
    public EventClickAyudante eventClickAyudante;
    public PlayerMovement playerMovement;
    public void StartDialogue()
    {      
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        uiSecondImage.Play("Helper");
        lineIndex = 0;
        StartCoroutine(ShowLine());
        playerMovement.moveSpeed = 0;
    }

    public void NextDialogueLine()
    {

       lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {           
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            lineIndex = 0;
            uiSecondImage.Play("Null");
            playerMovement.moveSpeed = 6f;
            StartCoroutine(DialogueCoolDown());                      
        }    
    }
    

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSeconds(typingTime);
        }
    }
    private IEnumerator DialogueCoolDown()
    {
        yield return new WaitForSeconds(.3f);
        eventClickAyudante.hasClicked = false;
        Debug.Log("CoolDown" + name + "Ended");
    }
}
