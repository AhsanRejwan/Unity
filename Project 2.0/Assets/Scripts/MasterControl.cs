using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterControl : MonoBehaviour {
    public static Camera MainCam;
    Scene scene;

    private void Start()
    {
        MainCam = GetComponent<Camera>();
        scene = SceneManager.GetActiveScene();
    }
    Vector2 obpos;
    public void obcaller(GameObject obj)
    {
        //obpos = new Vector2(0, 0);
        obpos = new Vector2(MainCam.ScreenToWorldPoint(Input.mousePosition).x, MainCam.ScreenToWorldPoint(Input.mousePosition).y);
        Instantiate(obj, obpos, Quaternion.identity);
    }

    //restart level
    public void restart()
    {
        SceneManager.LoadScene(scene.name);
    }
}
