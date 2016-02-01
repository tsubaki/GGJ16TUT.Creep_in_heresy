using UnityEngine;
using System.Collections;

public class BarrierRotate : MonoBehaviour {
    public Vector3 rotateSpeed = new Vector3(10f, 20f, 0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(rotateSpeed);
	}
}
