﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    public string estado;
    private string AR = "ar";
    private string CHAO = "chao";

    private float jumpTimeCounter;
    public float jumpTime;
       
    public float maxSpeed;
    public float jumpForce;

    private bool grounded;
    private bool jumping;

    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer sprite;


    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao")
        {
            estado = CHAO;
        }
        //plataforma
        if(collision.gameObject.tag.Equals("Chao"))
        this.transform.parent = collision.transform;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (estado == CHAO)
        {
            if (collision.gameObject.tag == "Chao")
            {
                estado = AR;
            }
        //plataforma
        if(collision.gameObject.tag.Equals("Chao"))
        this.transform.parent = null;
        
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && estado==CHAO)
        {
            jumping = true;
            rb2d.velocity = Vector2.up * jumpForce;
            jumpTimeCounter = jumpTime;            
        }
        
        if (Input.GetButtonDown("Jump") && jumping==true)
        {

            if (jumpTimeCounter>0)
            {
                    rb2d.velocity = Vector2.up * jumpForce;
                    jumpTimeCounter -= Time.deltaTime;
                    
            }
        }
            
        else 
        { 
            jumping = false; 
                
        }
       
       anim.SetBool("jumpFall", estado == AR);

    }

    void FixedUpdate() 
    {
        float move = Input.GetAxis ("Horizontal");
        
        anim.SetFloat("Speed", Mathf.Abs(move));

        rb2d.velocity = new Vector2 (move * maxSpeed, rb2d.velocity.y);

        if ((move > 0f && sprite.flipX) || (move < 0f && !sprite.flipX))
        {
            Flip();
        }

    }

    void Flip()
    {
        sprite.flipX = !sprite.flipX;
    }
}
