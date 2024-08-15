using System.Collections;
using UnityEngine;
using TMPro;

public class ScriptDialogoFinal : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    public Sprite portrait;
    public UnityEngine.UI.Image uiImage;
    private float typingTime = 0.03f;
    public bool didDialogueStart;
    public int lineIndex;
    public EventClickFinal eventClickFinal;
    public PlayerMovement playerMovement;

    public void StartDialogue()
    {
        uiImage.sprite = portrait;
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
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
            uiImage.sprite = null;
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
        eventClickFinal.hasClicked = false;
        Debug.Log("CoolDown" + name + "Ended");
    }
}
