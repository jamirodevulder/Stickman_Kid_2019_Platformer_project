using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenSpikeTrapScript : MonoBehaviour {
    private GameObject trap;

    private void Start()
    {
        trap = gameObject.transform.GetChild(0).gameObject;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "player")
        {
           GameObject trap = gameObject.transform.GetChild(0).gameObject;
            trap.SetActive(true);
            StartCoroutine(removespike());
        }
    }

    IEnumerator removespike()
    {
        yield return new WaitForSeconds(1.6f);
        trap.SetActive(false);

    }
}
