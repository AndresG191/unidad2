using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class M1_HandlerUI : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI texto_Putuacion;
    [SerializeField] TextMeshProUGUI texto_Tiempo;
    int puntacion;
    int tiempo;
    void Start()
    {
        puntacion = 0;
        tiempo = 20;
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void agregaPunto(){
        puntacion++;
        texto_Putuacion.text = puntacion.ToString();
    }

    IEnumerator controlTiempo(){
        while (true)
        {
            tiempo--;
            texto_Tiempo.text = tiempo.ToString();
            yield return new WaitForSeconds(0.25f);
        }
    }
}
