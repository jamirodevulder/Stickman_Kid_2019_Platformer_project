using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 0;
    public float jumpspeed = 0;
    private bool jump = true;
    private bool down = false;
    private bool keyup = false;
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
        if (Input.GetKey(KeyCode.W) && GetComponent<Rigidbody2D>().velocity.magnitude <= 2)
        {
            if(jump)
            {
                jump = false;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
                down = true;
                
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (down)
            {
                
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -jumpspeed), ForceMode2D.Impulse);
                down = false;

            }
        }
      

        if(transform.position.y <= -3 && !GameObject.Find("cloud").GetComponent<TrapScript>().iamdead)
        {
            GameObject.Find("cloud").GetComponent<TrapScript>().fall();
            GameObject.Find("cloud").GetComponent<TrapScript>().iamdead = true;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "ground")
        {
            jump = true;
            down = false;
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

