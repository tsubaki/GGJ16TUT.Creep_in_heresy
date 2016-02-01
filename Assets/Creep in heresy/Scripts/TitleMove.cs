using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        checkInput();
	}

    void checkInput()
    {
        if(Input.GetAxis("Joy1Start") != 0 || Input.GetKeyDown(KeyCode.Return)) SceneManager.LoadScene("GameController");
    }
}
