using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalP_3 : MonoBehaviour
{
    public static bool pegouPortalP3;

    // Start is called before the first frame update
    void Start()
    {
        pegouPortalP3 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
        pegouPortalP3 = true;
    }
}
