using System.Collections;
using UnityEngine;
using TMPro;

public class ScriptDialogo : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    public Animator uiSecondImageAnim;
    public string animName;
    public Sprite playerExpresiones;
    public UnityEngine.UI.Image playerImage;
    private float typingTime = 0.03f;
    public bool didDialogueStart;
    public int lineIndex;
    public EventClick eventClick;
    public PlayerMovement playerMovement;
    public GameObject clueText;
    public ObtenerPista obtenerPista;

    public void StartDialogue()
    {
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
            playerMovement.moveSpeed = 6f;
            StartCoroutine(DialogueCoolDown());
            if(obtenerPista.clueObtained == false)
            {
                StartCoroutine(GetClue());
            }
            else
            {
                return;
            }
            
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
        eventClick.hasClicked = false;
        Debug.Log("CoolDown" + name + "Ended");
    }
    IEnumerator GetClue()
    {      
        obtenerPista.GiveClue();
        clueText.SetActive(true);
        yield return new WaitForSeconds(3f);
        clueText.SetActive(false);    
        Debug.Log("Te Dieron una Pista");         
    }
}
