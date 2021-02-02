using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    private Component SC_ClickSpawner;
    // Start is called before the first frame update
    void Start()
    {
        SC_ClickSpawner = GetComponent<SC_ClickSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseOver()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            
        }   //If your mouse hovers over the GameObject with the script attached, output this message
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
    }
}
