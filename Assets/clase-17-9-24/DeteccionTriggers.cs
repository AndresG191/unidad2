using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionTriggers : MonoBehaviour
{
  [SerializeField] GameObject PlanchaResultado;
  Renderer rend;
  Material material;
  Material color_Original;

  public void Start(){
    rend= GetComponent<Renderer>();
    material = rend.material;
    color_Original = PlanchaResultado.GetComponent<Renderer>().material;
  }
  private void OnTriggerEnter(Collider other){
    PlanchaResultado.GetComponent<Renderer>().material =material;
  }
  private void OnTriggerStay(Collider other){
    Debug.Log("Stay");
  }
  private void OnTriggerExit(Collider other){
    PlanchaResultado.GetComponent<Renderer>().material = color_Original;
  } 
}
