using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DestruyeObjetos : MonoBehaviour
{

    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.GameObject;
        //if (objeto.name != "Plane" && objeto.name != "Muro" && objeto.name !="Muro2"){
        if(!objecto.CompareTag("NoRompible")){
            Destroy(object);
        }
    }
 
}
