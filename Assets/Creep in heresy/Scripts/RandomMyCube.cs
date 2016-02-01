using UnityEngine;
using System.Collections;

public class RandomMyCube : MonoBehaviour {
    public GameObject[] myCubes = new GameObject[4];
    //SkinnedMeshRenderer skinnedMeshRenderer;
    System.Random random = new System.Random();

	// Use this for initialization
	void Start () {
        int number = random.Next(3);
        Debug.Log(number);
        var myCube = Instantiate(myCubes[number], new Vector3(0, -1, 0), new Quaternion(0, 0, 0, 0));
        myCube.name = "MyCube";
    }

    // Update is called once per frame
    void Update () {
    }
}
