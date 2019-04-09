using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour {
    public GameObject[] points;
    private int count;
	// Use this for initialization
	void Start () {
      count = GameObject.Find("points").transform.childCount;
        points = new GameObject[count];
        print(count);
	}
	

    public void SetPoints(GameObject score)
    {
        
        for(int i = 0; i < count; i++)
        {
            
            if (points[i] == null)
            {

                points[i] = score;
                break;
            }
        }
    }
    public void CheckThePoints()
    {
        int check = 0;
        for (int i = 0; i < count; i++)
        {
            if (points[i] != null && points[i].tag == "score")
            {
                check++;

                if(check == count)
                {
                  print("win");
                }
               
            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
