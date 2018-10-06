using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    // Use this for initialization
    public Transform playa;
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = playa.position + new Vector3(0, .7f, -3); 
	}
}
