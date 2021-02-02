using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        maincamera.GetComponent<SC_ClickSpawner>().canSpawnHere = false;
        print("NON SI PUò");
    }

    private void OnMouseExit()
    {
        maincamera.GetComponent<SC_ClickSpawner>().canSpawnHere = true;
    }
}
