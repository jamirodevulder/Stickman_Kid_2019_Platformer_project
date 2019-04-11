using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayer : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        Instantiate(player, new Vector3(-5, -1, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
