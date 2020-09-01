using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcionaBotao2 : MonoBehaviour
{
    public static bool acionouBotao;
    private SpriteRenderer renderSprite, spriteRenderer;
    private AudioSource botao1;

    void Start ()
    {
        acionouBotao = false;
        renderSprite = GameObject.Find ("botões_2").GetComponent<SpriteRenderer>();
        spriteRenderer = GameObject.Find ("botões_3").GetComponent<SpriteRenderer>();
        botao1 = GetComponent<AudioSource>();
    }
 
    void OnTriggerEnter2D (Collider2D col)
    {
        renderSprite.GetComponent<SpriteRenderer>().enabled = false;
        spriteRenderer.GetComponent<SpriteRenderer>().enabled = true;
        acionouBotao = true;
        botao1.Play();
    }
    
}
