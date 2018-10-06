using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    float rand;
    Rigidbody2D ball;
    public int speed;
    
    
   
    // Use this for initialization
    void Start () {
        StartCoroutine(Example());
        ball = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.collider.tag =="Player")
        {
            //Rigidbody2D collid = col.collider.GetComponent<Rigidbody2D>();
            Vector2 vely = ball.velocity;
            vely.y = vely.y/2 + col.collider.GetComponent<Rigidbody2D>().velocity.y/3;
            ball.velocity = vely;
        }
    }

    void ballstarts()
    {
       
        ball.velocity = new Vector2(0, 0);
        //StartCoroutine(Example());
        rand = Random.Range(0, 2);
        if (rand <= .5)
        {
            ball.AddForce(new Vector2(speed, 10));
        }
        else
        {
            ball.AddForce(new Vector2(-speed, -10));
        }
    }
    void resetball()
    {
        ball.velocity = new Vector2(0, 0);
        ball.position = new Vector2(0, 0);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        ballstarts();
    }
}
