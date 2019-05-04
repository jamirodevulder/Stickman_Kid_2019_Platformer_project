using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapScript : MonoBehaviour {
    private bool ishit = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.name == "player" && !ishit)
        {
            print("test2");
            ishit = true;
            GameObject.Find("dead").GetComponent<deadhandler>().fall();
            GameObject.Find("dead").GetComponent<deadhandler>().iamdead = true;
            StartCoroutine(Hit());
        }
    }


    IEnumerator Hit()
    {

        yield return new WaitForSeconds(2);
        ishit = false;

    }
}
