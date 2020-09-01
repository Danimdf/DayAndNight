using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalB_1 : MonoBehaviour
{
    public static bool pegouPortalB1;
    private AudioSource portal;


    // Start is called before the first frame update
    void Start()
    {
        pegouPortalB1 = false;
        portal = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        portal.Play();
        Destroy(this.gameObject);
        pegouPortalB1 = true;
    }
}
