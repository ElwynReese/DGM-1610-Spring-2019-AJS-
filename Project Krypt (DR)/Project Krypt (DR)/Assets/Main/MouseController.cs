using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class MouseController : MonoBehaviour
{
    public LayerMask clickableObject;

    public Texture2D pointer;

    public Texture2D target;

    public Texture2D combat;

    public Texture2D doorway;
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit, 50, clickableObject.value))
        {
            bool door = false;
            if (Hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                door = true;
            }
            else
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }
        }
        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}
