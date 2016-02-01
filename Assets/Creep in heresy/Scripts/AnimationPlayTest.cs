using UnityEngine;
using System.Collections;

public class AnimationPlayTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            Debug.Log("check");
            gameObject.GetComponent<Animator>().Play("Pressed");
        }
	}
} 
