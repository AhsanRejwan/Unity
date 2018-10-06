using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D gl)
    {
        if (gl.name == "Ball")
        {
            var wallname = transform.name;
            GameManager.Score(wallname);
            gl.gameObject.SendMessage("resetball");
        }
    }
}
