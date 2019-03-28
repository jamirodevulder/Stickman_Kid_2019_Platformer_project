using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
     
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x >= 0.15)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10f, -10);
        }
        else if(player.transform.position.x <= 0.15)
        {
            transform.position = new Vector3(0.15f, transform.position.y, -10);
        }
	}
}
