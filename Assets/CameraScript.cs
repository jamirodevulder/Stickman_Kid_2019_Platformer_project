using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    private GameObject player;
    private float startypos;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        startypos = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x >= 0.15 && player.transform.position.y >= -1.1)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, -10);
        }
        else if(player.transform.position.x <= 0.15 && player.transform.position.y >= -1.1)
        {
            transform.position = new Vector3(0.15f, player.transform.position.y + 1, -10);
        }
        else if (player.transform.position.x >= 0.15)
        {
            transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
        else if (player.transform.position.x <= 0.15)
        {
            transform.position = new Vector3(0.15f, 0, -10);
        }



    }
}
