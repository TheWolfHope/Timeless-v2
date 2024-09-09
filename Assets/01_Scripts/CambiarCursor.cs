using UnityEngine;

public class CambiarCursor : MonoBehaviour
{
    [SerializeField] private ColliderItems collItem;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Texture2D spriteCursor;
    public Texture2D questionCursor;
    public Texture2D questionCursorInteract;
    void Start()
    {
        Cursor.SetCursor(spriteCursor, Vector2.zero, cursorMode);
        collItem = GetComponent<ColliderItems>();
    }

    void OnMouseOver()
    {
        {
            if(collItem.colliderEnter == false)
            {
                Cursor.SetCursor(questionCursor, Vector2.zero, cursorMode);
            }
            else
            {
                Cursor.SetCursor(questionCursorInteract, Vector2.zero, cursorMode);
            }
            
        }      
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(spriteCursor, Vector2.zero, cursorMode);
    }
}
