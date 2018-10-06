using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector2 pos,rot;
    float x;
    int rotflag =0, conflag =0, colflag =0;
    PolygonCollider2D maincol;
    Rigidbody2D rb;
    SpriteRenderer sp;
    Color originalcol;

    private void Start()
    {
        maincol = GetComponent<PolygonCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        maincol.isTrigger = true;
        rb.Sleep();
        sp = GetComponent<SpriteRenderer>();
        originalcol = sp.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(conflag == 0)
        { 
            pos = new Vector2(MasterControl.MainCam.ScreenToWorldPoint(Input.mousePosition).x, MasterControl.MainCam.ScreenToWorldPoint(Input.mousePosition).y);
            if (rotflag == 0)
            {
                transform.position = pos;
            }
            if (Input.GetMouseButton(1))
            {
                rotflag = 1;
                rot = new Vector2(pos.x - transform.position.x, pos.y - transform.position.y);
                transform.up = rot;

            }
            else
            {
                rotflag = 0;
            }
            if (Input.GetMouseButtonDown(0) && colflag ==0)
            {
                confirm();
            }
            
        }
	}

    void confirm()
    {
        if (rb.GetComponent<AreaEffector2D>() != null)
            rb.SendMessage("done");
        maincol.isTrigger = false ;     
        rb.WakeUp();
        conflag = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (conflag == 0)
        {
             sp.color = Color.red;
            colflag = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sp.color = originalcol;
        colflag = 0;
    }
}
