using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {
    public Sprite cloudLightning;
    public Sprite cloud;
    private GameObject player;
    private Component movement;
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
            GetComponent<SpriteRenderer>().sprite = cloudLightning;
            player.GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(dead());
            
            
        }
    }
    IEnumerator dead()
    {
       yield return new WaitForSeconds(1.5f);
        GetComponent<SpriteRenderer>().sprite = cloud;
        player.transform.position = new Vector3(-5, -1, 0);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
