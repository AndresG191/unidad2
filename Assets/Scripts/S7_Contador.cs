using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S7_Contador : MonoBehaviour
{
    [SerializeField] ChangeScene auxiliar;
    [SerializeField] S8_DestruyeObjetos2 aux_cont_enemigos;
    int contador;
    [SerializeField] TextMeshProUGUI texto_contador;
    void Start()
    {
        contador = 10;
        StartCoroutine(corrutina_contador());
    }

    IEnumerator corrutina_contador(){
        while(contador > 0){
            contador--;
            texto_contador.text = contador.ToString();
            yield return new WaitForSeconds(0.5f); 
        }
        int puntuacion =  aux_cont_enemigos.contador;
        auxiliar.cambioEscena(2, puntuacion);
    }
}
