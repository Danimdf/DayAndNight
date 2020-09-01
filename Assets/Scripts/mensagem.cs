using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mensagem : MonoBehaviour {

      public TMP_Text texto;
      private GameObject Jogador;
      [Range(5.0f,10.0f)]public float distancia = 10;

      void Start () {
            texto.enabled = false;
            Jogador = GameObject.FindWithTag ("PlayerS");
      }


      void Update ()
      {
            if (Vector3.Distance (transform.position, Jogador.transform.position) > distancia) {
                  texto.enabled = true;
            } else {
                  texto.enabled = false;
            }
      }
}