using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CameraFollowL : MonoBehaviour
{
 public GameObject followObject;
    public Vector2 followOffset;
    public float speed = 3f;
    private Vector2 threshold;
    private Rigidbody2D rb;

    public GameObject Jogador1;
    public GameObject Jogador2;

    // Start is called before the first frame update
    void Start()
    {
        threshold = calculateThreshold();
        rb = followObject.GetComponent<Rigidbody2D>();

        Jogador1 = GameObject.FindWithTag("PlayerL");
        Jogador2 = GameObject.FindWithTag("PlayerS");
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.C))
        {
            Jogador1.GetComponent<PlayerL>().enabled = false;
            Jogador2.GetComponent<PlayerS>().enabled = true;
            followObject = Jogador2;
        }

        if (Input.GetKeyDown (KeyCode.T))
        {
            Jogador1.GetComponent<PlayerL>().enabled = true;
            Jogador2.GetComponent<PlayerS>().enabled = false;
            followObject = Jogador1;
        }

        if (PortalB_1.pegouPortalB1 == true && PortalP_1.pegouPortalP1 == true)
        {
            SceneManager.LoadScene("Level_2");
        }

        if (PortalB_2.pegouPortalB2 == true && PortalP_2.pegouPortalP2 == true)
        {
            SceneManager.LoadScene("Level_3");
        }

        if (PortalB_3.pegouPortalB3 == true && PortalP_3.pegouPortalP3 == true && PortalB_4.pegouPortalB4 == true && PortalP_4.pegouPortalP4 == true)
        {
            SceneManager.LoadScene("cutscenefinal");
        }

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKeyDown (KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 follow = followObject.transform.position;
        float xDifference = Vector2.Distance(Vector2.right * transform.position.x, Vector2.right * follow.x);
        float yDifference = Vector2.Distance(Vector2.up * transform.position.y, Vector2.up * follow.y);

        Vector3 newPosition = transform.position;
        if (Mathf.Abs(xDifference) >= threshold.x)
        {
            newPosition.x = follow.x;
        }

        if (Mathf.Abs(yDifference) >= threshold.y)
        {
            newPosition.y = follow.y;
        }
        float moveSpeed = rb.velocity.magnitude > speed ? rb.velocity.magnitude : speed;
        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

    }

    private Vector3 calculateThreshold()
    {
        Rect aspect = Camera.main.pixelRect;
        Vector2 t = new Vector2(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize);
        t.x -= followOffset.x;
        t.y -= followOffset.y;
        return t;
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Vector2 border =  calculateThreshold();
        Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
    }

}

