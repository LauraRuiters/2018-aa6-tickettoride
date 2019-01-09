using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinGedrag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color [] colors;
	Material [] materials;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)) {
	material.Renderer.material.color = Color.red; 
    }
}
}