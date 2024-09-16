using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class S7_Contador : MonoBehaviour
{   
    int cont;
    
    [SerializeField] TextMeshProUGUI texto_contador;
    // Start is called before the first frame update
    void Start()
    {
        cont = 10;
        StartCoroutine(corrutina_contador()); // compartir recursos en un hilo dependiente sin depender de los demas
                                                // la corutina esta optimizada
    }

     IEnumerator corrutina_contador(){
            while(cont>0){
            cont--;
            texto_contador.text = cont.ToString();
                yield return new WaitForSeconds(0.5f);
            }
            //SceneManager.LoadScene(7);..... ME LLEVA A UNA ESCENA SI SE ME ACABA EL TIEMPO
            //int score = aux_cont_enemigo.contador;
            //auxiliar.cambioEscena(2, score);//ESCENA FIN JUEGO

            // ponemos el nombre de la escena SceneManager.LoadScene(7); que me lleve a una escena si se me acaba el tiempo
        }
        //si queremos usar un metodo en clase a y queremos usararlo en clase B tiene que ser publico en la clase A
        //y si es en una variable tiene que ser obligatorio a publicas, es necesario hacerlas todas? no, solo las que queremos que se comuniquen, ahi se hacen publicas.
//idear dinamica que podamos resolver o ejecutar que se pueda resolver con base a lo que hemos visto hasta ahora.
}
