using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectorControl : MonoBehaviour {

     BoxCollider2D col;
	// Use this for initialization
	void Start () {
        col = GetComponent<BoxCollider2D>();
        col.GetComponent<AreaEffector2D>().enabled = false;
        col.isTrigger = false;
        col.enabled = false;
	}
	
	void done()
    {
        col.enabled = true;
        col.isTrigger = true;
        col.GetComponent<AreaEffector2D>().enabled = true;
    }
}
