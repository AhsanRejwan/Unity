using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCore : MonoBehaviour {

    public Transform player;
    float x=0;
    public bool gameover = false;
    public Text score;
    public Text Highscore;

    private void Start()
    {
        Highscore.text += PlayerPrefs.GetInt("high",0).ToString();
    }
    // Update is called once per frame
    void Update () {
        if (player.position.z >= x && gameover == false)
        {
            x = player.position.z;
        }


        if(gameover == true && x > PlayerPrefs.GetInt("high", 0))
        {
            PlayerPrefs.SetInt("high",(int)x);
            Highscore.text += PlayerPrefs.GetInt("high", 0).ToString();
        }

        score.text = x.ToString("0");
	}
    
}
