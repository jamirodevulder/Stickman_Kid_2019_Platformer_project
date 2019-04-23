using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextScript : MonoBehaviour {
    bool arrowkeys = false;
    public Text buttontext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!arrowkeys)
        {
            buttontext.text = "Pijltjestoetsen Besturing";
        }
        else if (arrowkeys)
        {
            buttontext.text = "WASD Besturing";
        }
    }

    public void changeText() { 

        if(!arrowkeys)
        {
            arrowkeys = true;
            
        }
        else if(arrowkeys)
        {
            arrowkeys = false;
            
        }
    }
}
