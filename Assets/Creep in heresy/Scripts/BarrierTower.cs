using UnityEngine;
using System.Collections;

public class BarrierTower : MonoBehaviour {

	[SerializeField]
	GameObject target;


	void Update()
    {
        if (Time.frameCount % 3 == 0)
        {
            if (transform.childCount < 2)
            {
                enabled = false;
                target.SetActive(false);
            }
        }
    }
}
