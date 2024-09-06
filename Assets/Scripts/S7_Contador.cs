using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S7_Contador : MonoBehaviour
{

    int cont;
    [SerializeField] TextMeshProUGUI contador;
    // Start is called before the first frame update
    void Start()
    {
        cont = 10;
        StartCoroutine("Corrutina_contador"); // compartir recursos en un hilo dependiente sin depender de los demas
                                                // la corutina esta optimizada
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     IEnumerator corrutina_contador(){
            while(cont>0){
            cont--;
            texto_contador.text = cont.ToString();
                yield return new WaitForSeconds(0.5f)
            }

            // ponemos el nombre de la escena SceneManager.LoadScene(7); que me lleve a una escena si se me acaba el tiempo
        }
}
