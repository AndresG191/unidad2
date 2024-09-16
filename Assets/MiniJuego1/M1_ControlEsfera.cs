using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1_ControlEsfera : MonoBehaviour
{
    //[SerializeField] GameObject spawn1;
    //[SerializeField] GameObject spawn2;

    [SerializeField] List<GameObject> spawns; //lista de spawns (que son Gameobjects!)
    int index;
    
    float tiempo_en_colision;
    private void OnCollisionEnter(Collision other) {
        tiempo_en_colision=0;
        if(other.gameObject.CompareTag("Player")){
        mueveEsfera();
        }

    }

        private void OnCollisionStay(Collision other){
            //Cuando la esfera colisione con cualquier objeto, cambiara su posicion actual 
        //para irse a alguno de los posibles spawns. El movimiento es aleatorio

        //Se requiere conocer cuales son los posibles spawns.....
            
        tiempo_en_colision += Time.deltaTime;
        //Debug.Log(tiempo_en_colision.ToString());  <-- linea solo para testear el tiempo de colision

        if(tiempo_en_colision>0.5f){ //mayor de medio segundo
            mueveEsfera();
        }

    }
    private void mueveEsfera(){
         //Funcionalidad del collision...
            index = Random.Range(0, spawns.Count); //Exclusivo el lim superior  [0, n-1]

            //Como la esfera es la que tiene el script, entonces puedo usar directamente: trasform.position

            transform.position = spawns[index].transform.position; //reposiciona la esfera
    }
}