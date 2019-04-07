using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadhandler : MonoBehaviour {
    private GameObject player;
    public bool iamdead = false;
    private bool check = false;
    public void fall()
    {
        player = GameObject.Find("player");
        StartCoroutine(dead());
        

    }


    IEnumerator dead()
    {
        if (!check)
        {
            check = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            yield return new WaitForSeconds(1.5f);
            player.transform.position = new Vector3(-7.24f, -0.8f, 0);
            GameObject camera = GameObject.Find("Main Camera");
            camera.transform.position = new Vector3(0.15f, 0, -10);
            player.GetComponent<PlayerMovement>().enabled = true;
            iamdead = false;
            check = false;
        }
    }


}
