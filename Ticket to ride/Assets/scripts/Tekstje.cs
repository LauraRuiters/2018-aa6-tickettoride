using UnityEngine;
using System.Collections;

public class Tekstje : MonoBehaviour
{
      float tijd = 5f; //Seconds to read the text

    void Start()
    {
        Invoke("Hide", tijd);
              }

    void Hide()
    {
        Destroy(gameObject);
    }
    
 }

