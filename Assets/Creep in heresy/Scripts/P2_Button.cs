using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class P2_Button : MonoBehaviour
{
	private bool isDoubleTap;
	private float doubleTapTime;
	RaycastHit hit;

	Camera_ray Ray;

	[SerializeField]
	Transform target;

	[SerializeField]
	Vector2 offset;

	void Start ()
	{
		Ray = FindObjectOfType<Camera_ray> ();
	}

	void Update ()
	{
			var image = GetComponent<Image> ();
			if (Ray.p1 != null) {
				image.enabled = true;
				var canvas = image.canvas;

				var pos = RectTransformUtility.WorldToScreenPoint (Camera.main, Ray.p1.transform.position);
				var pos2 = Input.mousePosition; 
				transform.position = offset + pos; 
				} else {
					image.enabled = false;

			}
		}

	public void OnClickDes(){
		Destroy (Ray.p1);

	}
}
