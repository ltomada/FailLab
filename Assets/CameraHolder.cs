using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public float mSpeed;
    public float SensitivityX;
    public float SensitivityY;
    public float TargetAngleX;
    public float TargetAngleY;
    // Start is called before the first frame update  
    void Start()
    {
        mSpeed = 50f;
    }

    // Update is called once per frame  
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * mSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * mSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * mSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up, -.25f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.up, .25f);
        }

    }
}