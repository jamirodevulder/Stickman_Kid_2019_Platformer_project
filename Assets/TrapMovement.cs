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
            player.GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(dead());
            

        }
    }
    IEnumerator dead()
    {
        yield return new WaitForSeconds(1.5f);
        player.transform.position = new Vector3(-7.24f, -1, 0);
        camera.transform.position = new Vector3(0.15f, 0, -10);
        player.GetComponent<PlayerMovement>().enabled = true;
        Destroy(gameObject);
    }
}
