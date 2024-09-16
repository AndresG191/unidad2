using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class M1_ManagerUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI texto_puntuacion;
    int puntuacion;

    [SerializeField] TextMeshProUGUI texto_tiempo;
    int tiempo;

    void Start(){
        puntuacion = 0;
        tiempo = 20; //20 segundos de juego
        StartCoroutine("controltiempo");
    }

    void Update()
    {
        
    }

    public void agregaPunto(int puntos){
        puntuacion+= puntos;
        texto_puntuacion.text = puntuacion.ToString();
    }

    IEnumerator controlTiempo(){
        while(true){
            tiempo--;
            texto_tiempo.text = tiempo.ToString();
            yield return new WaitForSeconds(0.25F);
        }
    }
}
