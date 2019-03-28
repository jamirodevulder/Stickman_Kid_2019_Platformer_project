﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {
    public Sprite cloudLightning;
    public Sprite cloud;
    private GameObject player;
    private Component movement;
    private GameObject camera;
    public bool iamdead;
    // Use this for initialization
    void Start () {
       player = GameObject.Find("player");
        camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "player")
        {
            GetComponent<SpriteRenderer>().sprite = cloudLightning;
            player.GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(dead());
            
            
        }
    }
    IEnumerator dead()
    {
       yield return new WaitForSeconds(1.5f);
        GetComponent<SpriteRenderer>().sprite = cloud;
        player.transform.position = new Vector3(-7.24f, -1, 0);
        camera.transform.position = new Vector3(0.15f, 0, -10);
        player.GetComponent<PlayerMovement>().enabled = true;
        iamdead = false;
    }

    public void fall()
    {
        StartCoroutine(dead());
    }
}