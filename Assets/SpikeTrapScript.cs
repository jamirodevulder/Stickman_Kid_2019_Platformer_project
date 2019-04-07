using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapScript : MonoBehaviour {
    private bool ishit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player" && !ishit)
        {
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
