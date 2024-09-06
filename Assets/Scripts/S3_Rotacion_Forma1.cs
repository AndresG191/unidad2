using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Rotacion_Forma1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidad =15;
        float angulos = 5;
                        //x     //y     //z
        transform.Rotate(0, angulos, 0);
        
    }
}
