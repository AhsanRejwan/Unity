using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public KeyCode moveup, movedown;

    Vector2 speed = new Vector2(0,10);
    Rigidbody2D rb;
   
    private void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }
    void Update () {
		if(Input.GetKey(moveup))
        {
            rb.velocity = speed;
           
        }
        else if(Input.GetKey(movedown))
        {
            rb.velocity = speed * -1;
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
	}
}
