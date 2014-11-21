using UnityEngine;
using System.Collections;

public class GuiTexture : MonoBehaviour
{
    GUITexture attachedTexture;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (this.guiTexture.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Button X clicked");
        }
    }
}
