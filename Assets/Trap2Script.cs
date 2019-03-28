using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2Script : MonoBehaviour {
    private GameObject player;
    public GameObject spawnBall;
    // Use this for initialization
    void Start () {

        player = GameObject.Find("player");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {

            Instantiate(spawnBall, new Vector3(transform.position.x + 10, transform.position.y, transform.position.z), Quaternion.identity);

           


        }
    }

}
