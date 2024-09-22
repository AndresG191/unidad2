using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ChangeScene : MonoBehaviour
{
int puntuacion_score=0; 
    [SerializeField] TextMeshProUGUI valor_score;

    // Update is called once per frame
    void Update()
    {      
        int index_scene_active = SceneManager.GetActiveScene().buildIndex;  
        if(index_scene_active == 0){ //inicio
         
          if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(3); //Escena del juego         
          }  

        }
        else if(index_scene_active == 3){ //juego

        }
        else{ //escena final - index 2
              valor_score.text = PlayerPrefs.GetInt("Puntaje", 0).ToString();
        }


    }


    public void cambioEscena(int index){
        SceneManager.LoadScene(index);
    }

    public void cambioEscena(int index, int puntaje){
        PlayerPrefs.SetInt("Puntaje", puntaje); //almacenar en memoria "permanente" el valor
        cambioEscena(index);
    }

}