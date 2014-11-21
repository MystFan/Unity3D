using UnityEngine;
using System.Collections;

public class OnGuiScript : MonoBehaviour {

    public GUISkin mySkin;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(200, 100, 200, 100), "New Game"))
        {
            Debug.Log("Button X clicked");
        }



        GUI.skin = mySkin;

        if (GUI.Button(new Rect(200, 500, 200, 100), "Game Over"))
        {
            Debug.Log("Button X clicked");
        }
    }
}
