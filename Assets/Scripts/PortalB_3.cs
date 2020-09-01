using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalB_3 : MonoBehaviour
{
    public static bool pegouPortalB3;

    // Start is called before the first frame update
    void Start()
    {
        pegouPortalB3 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
        pegouPortalB3 = true;
    }
}
