using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.name == "player")
        {
            player.GetComponent<ScoreHandler>().SetPoints(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
