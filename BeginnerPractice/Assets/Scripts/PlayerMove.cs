using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Rigidbody rb;
    public float frontforce =0f;
    public float sideforce = 0f;
    public float jump = 0f;
    bool jflag = false;
    bool eflag = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
  
	}

	// Update is called once per frame
	void FixedUpdate () {

        if(rb.position.y < -0.6 && eflag == false)
        {
            eflag = true;
            FindObjectOfType<GameManager>().EndGame();
        }


        //forward force
        rb.AddForce(0,0,frontforce);
       

        //movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKeyDown("space") && jflag == false)
        {
            rb.velocity += Vector3.up * jump;
            
            jflag = true;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * 2.2f * Time.deltaTime;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {

            GetComponent<PlayerMove>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
        if(collision.collider.name == "Cube")
        {
            jflag = false;
            
        }
    }

}
