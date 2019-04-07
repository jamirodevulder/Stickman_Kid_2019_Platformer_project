using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    private GameObject player;
    private GameObject camera;
    public float movement;
    private bool nothit = true;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("player");
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;
        if(transform.position.x <= -10 && nothit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            nothit = false;
            GameObject.Find("dead").GetComponent<deadhandler>().fall();
            GameObject.Find("dead").GetComponent<deadhandler>().iamdead = true;
            Destroy(gameObject);

        }
    }
   
}
