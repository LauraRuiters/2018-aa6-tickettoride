using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeranderKleur : MonoBehaviour
{
    private void OnMouseDown()
    {
        // zet een nieuwe kleur op dak van de trein

        Renderer rend = GetComponent<Renderer>();


        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.green);


        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);

    }
}
