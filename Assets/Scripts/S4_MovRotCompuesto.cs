using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_MovRotCompuesto : MonoBehaviour
{

    [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //arriba - abajo
        if(Input.GetKeyDown(KeyCode.W)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }   else if(Input.GetKeyDown(KeyCode.S)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
            
        }
            //izquierda derecha 
         if(Input.GetKeyDown(KeyCode.A)){
            transform.position += velocidad_movimiento * -1* Time.deltaTime * transform.right;
        }   else if(Input.GetKeyDown(KeyCode.D)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;            
        }
            //rotar izquierda - rotar derecha
         if(Input.GetKeyDown(KeyCode.Q)){
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime, 0);
        }   else if(Input.GetKeyDown(KeyCode.E)){
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime, 0);
        }
    }
}
