using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalB_2 : MonoBehaviour
{
    public static bool pegouPortalB2;
    private AudioSource portalB2;

    // Start is called before the first frame update
    void Start()
    {
        pegouPortalB2 = false;
        portalB2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        portalB2.Play();
        Destroy(this.gameObject);
        pegouPortalB2 = true;
    }
}
