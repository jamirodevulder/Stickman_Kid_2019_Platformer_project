using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayGameScript : MonoBehaviour {

    
    
    public void play()
    {
        SceneManager.LoadScene("ShowCaseLVL");
    }

}
