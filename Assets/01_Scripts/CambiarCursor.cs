using UnityEngine;

public class CambiarCursor : MonoBehaviour
{
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Texture2D spriteCursor;
    public Texture2D questionCursor;
    void Start()
    {
        Cursor.SetCursor(spriteCursor, Vector2.zero, cursorMode);
    }

    void OnMouseOver()
    {
        if(gameObject.tag == "Interactuable")
        {
            Cursor.SetCursor(questionCursor, Vector2.zero, cursorMode);
        }      
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(spriteCursor, Vector2.zero, cursorMode);
    }
}
