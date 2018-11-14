using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenesjump2 : MonoBehaviour {

   // public Button bb1;
    public Button bb2;
    // Use this for initialization
    void Start()
    {
        //bb1.onClick.AddListener(fuck);
        bb2.onClick.AddListener(fucker);
    }



    // Update is called once per frame
    void Update()
    {

    }

    /*
    public void fuck()
    {
        Debug.Log("DIE");
        SceneManager.LoadScene("Scene 2", LoadSceneMode.Single);
    }
    */

    public void fucker()
    {
        Debug.Log("ajkw ehwuh");
        SceneManager.LoadScene("Scene 1", LoadSceneMode.Single);
    }
}
