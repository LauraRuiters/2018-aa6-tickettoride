using UnityEngine;
using System.Collections;

public class Tekstje : MonoBehaviour
{
      float tijd = 3f; //Seconds to read the text

    void Start()
    {
        Invoke("verdwijn", tijd);
              }

    void verdwijn()
    {
        Destroy(gameObject);
    }
    
 }

