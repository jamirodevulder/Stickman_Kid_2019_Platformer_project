﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 0;
    public float jumpspeed = 0;
    private bool jump = true;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(+speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if(jump)
            {
                jump = false;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);

                
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "ground")
        {
            jump = true;
        }
      
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            jump = false;
        }
    }


}

