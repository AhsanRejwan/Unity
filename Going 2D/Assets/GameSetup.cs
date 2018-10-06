using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

    public Camera MainCam;
    public BoxCollider2D TopWall, BottomWall, LeftWall, RightWall;
    public Transform P1, P2;
	 
	// Update is called once per frame
	void Start () {
        TopWall.size = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(Screen.width*2f,0f,0f)).x, 1f);
        TopWall.offset = new Vector2(0f, MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y+0.5f);

        BottomWall.size = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        BottomWall.offset = new Vector2(0f, MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y*-1-0.5f);

        LeftWall.size = new Vector2(1f,MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
        LeftWall.offset = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x*-1 -0.5f,0f);

        RightWall.size = new Vector2(1f,MainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height * 2f, 0f)).y);
        RightWall.offset = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f,0f);

        P1.position = new Vector2 (MainCam.ScreenToWorldPoint(new Vector3 (75f,0f,0f)).x,0);
        P2.position = new Vector2 (MainCam.ScreenToWorldPoint(new Vector3(Screen.width-75f,0f,0f)).x,0);
    }
}
