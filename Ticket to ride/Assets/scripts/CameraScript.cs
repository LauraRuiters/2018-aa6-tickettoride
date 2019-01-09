using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float snelheid = 55.0f;
    private float zoomSpeed = 9.0f;




// Use this for initialization
void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(snelheid * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-snelheid * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -snelheid * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, snelheid * Time.deltaTime, 0));
        }

    {

    float scroll = Input.GetAxis("Mouse ScrollWheel");
    transform.position += this.transform.forward * scroll * zoomSpeed;
}



    }
}
