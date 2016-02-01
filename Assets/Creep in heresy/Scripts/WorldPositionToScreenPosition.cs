using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorldPositionToScreenPosition : MonoBehaviour
{
	Camera_ray cameraRay;

	[SerializeField]
	Transform target;

	[SerializeField]
	Vector2 offset;

	void Start ()
	{
		cameraRay = FindObjectOfType<Camera_ray> ();
	}

	void Update ()
	{
		var image = GetComponent<Image> ();
		if (cameraRay.p1 != null) {
			image.enabled = true;
			var canvas = image.canvas;

			var pos = RectTransformUtility.WorldToScreenPoint (Camera.main, cameraRay.p1.transform.position);
			transform.position = offset + pos ;
		}else{
			image.enabled = false;
		}

	}
}
