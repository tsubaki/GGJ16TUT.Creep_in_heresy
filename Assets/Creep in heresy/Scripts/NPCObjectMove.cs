using UnityEngine;
using System.Collections;

public class NPCObjectMove : MonoBehaviour {
    
    public float speed = 0.1f;
    public bool canMoveing = true;  //Path2のため

	// Use this for initialization
	void Start () {
        //NPC同士の判定を消す
        int neglectLayer = LayerMask.NameToLayer("NPC");
        Physics.IgnoreLayerCollision(neglectLayer, neglectLayer);
    }
	
	// Update is called once per frame
	void Update () {
        if(canMoveing)
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;

		GetComponentInChildren<Animator>().SetBool("IsWalking", canMoveing);
    }
}
