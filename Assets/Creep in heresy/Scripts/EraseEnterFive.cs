using UnityEngine;
using System.Collections;

public class EraseEnterFive : MonoBehaviour
{
	void OnTriggerEnter (Collider c)
	{
		if (c.CompareTag ("Player1"))
			GameObject.Destroy (gameObject, Random.Range (4f, 7f));
	}
}
