using System.Collections;
using UnityEngine;
using TMPro;
public class ScriptDialogoDeMuerte : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    public Sprite portrait;
    public UnityEngine.UI.Image uiImage;
     public Animator uiSecondImageAnim;
    public string animName;
    private float typingTime = 0.03f;
    public bool didDialogueStart;
    public int lineIndex;
    public PlayerMovement playerMovement;

    public bool seIniciaGamerOver = false;

   

    public void StartDialogue()
    {
        uiImage.sprite = portrait;
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        uiSecondImageAnim.Play(animName);
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
            uiSecondImageAnim.Play("Null");
            dialoguePanel.SetActive(false);
            lineIndex = 0;
            uiImage.sprite = null;
            playerMovement.moveSpeed = 6f;
            seIniciaGamerOver = true;
            //StartCoroutine(DialogueCoolDown());
            
          
            
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
        Debug.Log("CoolDown" + name + "Ended");
    }

}
