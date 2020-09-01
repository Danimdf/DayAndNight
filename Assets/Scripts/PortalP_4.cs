using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalP_4 : MonoBehaviour
{
    public static bool pegouPortalP4;

    // Start is called before the first frame update
    void Start()
    {
        pegouPortalP4 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
        pegouPortalP4 = true;
    }
}
