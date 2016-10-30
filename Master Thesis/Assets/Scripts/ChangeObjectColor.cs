using UnityEngine;
using System.Collections;

public class ChangeObjectColor : MonoBehaviour {

    public GUISkin GameSkin;
    private Color startColor;
    
    void OnGUI()
    {
        GUI.skin = GameSkin;
    }

    void OnMouseEnter()
    {
        startColor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }
}
