using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {
    public Sprite cloudLightning;
    public Sprite cloud;
    private GameObject player;
    private Component movement;
    private GameObject camera;
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
            StartCoroutine(lightning());
            GameObject.Find("dead").GetComponent<deadhandler>().fall();
            GameObject.Find("dead").GetComponent<deadhandler>().iamdead = true;
        }
    }
    IEnumerator lightning()
    {
       yield return new WaitForSeconds(1.6f);
        GetComponent<SpriteRenderer>().sprite = cloud;
      

    }
}
