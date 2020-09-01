using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaBotao : MonoBehaviour
{
    public static bool acionouBotao;
    private SpriteRenderer renderSprite, spriteRenderer;
    private AudioSource botao;

    void Start ()
    {
        acionouBotao = false;
        renderSprite = GameObject.Find ("botões_0").GetComponent<SpriteRenderer>();
        spriteRenderer = GameObject.Find ("botões_1").GetComponent<SpriteRenderer>();
        botao = GetComponent<AudioSource>();
    }
 
    void OnTriggerEnter2D (Collider2D col)
    {
        renderSprite.GetComponent<SpriteRenderer>().enabled = false;
        spriteRenderer.GetComponent<SpriteRenderer>().enabled = true;
        acionouBotao = true;
        botao.Play();
    }
    
}
