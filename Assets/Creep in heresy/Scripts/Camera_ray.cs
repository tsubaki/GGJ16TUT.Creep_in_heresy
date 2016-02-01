using UnityEngine;
using System.Collections;

public class Camera_ray : MonoBehaviour
{

	public Camera cam = null;
	public LayerMask NPC;
	public GameObject p1;

	void Start ()
	{
	}

	void Update ()
	{
		RaycastHit hit = new RaycastHit ();
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);


		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit, 10000, NPC)) {
				
				p1 = hit.collider.gameObject;
			}else{
				p1 = null;
			}
		}
	}
}