using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject Complete, Over;
	// Use this for initialization
	public void EndGame()
    {
        Over.SetActive(true);
        FindObjectOfType<PlayerMove>().enabled = false;
        FindObjectOfType<SCore>().gameover = true;
        Invoke("Restart",3f);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteGame()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        FindObjectOfType<SCore>().gameover = true;
        Complete.SetActive(true);
    }
}
