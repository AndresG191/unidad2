using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_CaidaPersonaje : MonoBehaviour
{
    float valor_y;
    [SerializeField] Transform spawn;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){

    }
    void Update()
    {
        valor_y = transform.position.y; //SE OBTIENE LA POSICION EN "Y" DEL OBJETO

        if(valor_y <0){ //SI EL OBJETO CAE MAS DE 10 UNIDADES EN "Y"
            transform.position = spawn.position; //LO REGRESA A LA POSICION 0,0,0
        }
    }
}
