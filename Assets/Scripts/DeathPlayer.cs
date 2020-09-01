using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
   public static bool morto = false;
    public GameObject gameoverPanel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "deadly")
        {
            morto = true;
            gameoverPanel.SetActive (true);
            Time.timeScale = 0;
        }
    }
}
