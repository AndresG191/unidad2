using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Rotacion_Forma1 : MonoBehaviour
{
   [SerializeField] private float velocidad = 15;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angulos = 5 * Time.deltaTime * velocidad;
        transform.Rotate(0, angulos, 0);
    }
}
