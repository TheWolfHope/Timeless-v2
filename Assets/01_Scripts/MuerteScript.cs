using UnityEngine;
public class MuerteScript : MonoBehaviour
{
    public CanvasScript canvasScript;
    public ScriptDialogoDeMuerte scriptDialogo1;
    public bool empiezaDialogo = false;
    public bool puedeMoverse = true;
    public Vector3 posicionCuandoLoMata;
    public PlayerAnimations playerAnimations;

    public GameObject player;

    //public string nombrePanel = "MenuDePistas";



    private void Start()
    {
        // Busca y asigna autom�ticamente el script CanvasScript en la escena
        canvasScript = FindObjectOfType<CanvasScript>();
        scriptDialogo1 = FindObjectOfType<ScriptDialogoDeMuerte>();
        playerAnimations = FindObjectOfType<PlayerAnimations>();

        player = GameObject.Find("Player");

        //GameObject panel = GameObject.Find(nombrePanel);
    }

    private void Update()
    {
        if (scriptDialogo1.seIniciaGamerOver)
        {
            canvasScript.GameOver();
            Destroy(this.gameObject);
            Destroy(player);
            //Destroy(collision.gameObject);
        }

        if (!puedeMoverse)
        {
            transform.position = posicionCuandoLoMata;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvasScript.CerrarTodoParaQueSeaBienAlaHoraDeCuandoTeMaten();
            scriptDialogo1.StartDialogue();
            posicionCuandoLoMata = transform.position;
            puedeMoverse = false;
           playerAnimations.canMove = false;
        }
    }

   
}