using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static int p1score = 0, p2score = 0;
    public GUISkin theskin;
	// Update is called once per frame
	static public void Score (string wallname) {

    if(wallname == "LeftWall")
        {
            p2score += 1;
        }
    else
        {
            p1score += 1;
        }
        Debug.Log("p1" + p1score);
        Debug.Log("p2" + p2score);
		}
    private void OnGUI()
    {
        GUI.skin = theskin;
        GUI.Label(new Rect(Screen.width / 2 - 150-12, 20, 100, 100), ""+p1score);
        GUI.Label(new Rect(Screen.width / 2 + 150-12, 20, 100, 100),  ""+p2score);
    }
}
