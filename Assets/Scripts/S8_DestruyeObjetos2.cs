using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S8_DestruyeObjetos2 : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI texto_puntuacion;

    int contador=0;

    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        //if (objeto.name != "Plane" && objeto.name !="Muro" && objeto.name !="Muro2")
        if (!objeto.CompareTag("NoRompible")){
            contador++;
            texto_puntuacion.text = contador.ToString();
            Destroy(objeto);
        }
    }
}
