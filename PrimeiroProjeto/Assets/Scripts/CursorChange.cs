using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour {

    public Texture2D mousePonteiro;
    public Texture2D mousePonteiroClick;
    public Texture2D mousePonteiroWait;

    // Use this for initialization
    void Start () {
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Cursor.SetCursor(mousePonteiroClick, Vector2.zero, CursorMode.Auto);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Cursor.SetCursor(mousePonteiroWait, Vector2.zero, CursorMode.Auto);
        }
    }
}
