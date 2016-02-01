using UnityEngine;
using System.Collections;

public class Path03 : RootPath
{
    Coroutine cor;

    public float t1 = 1.0f;
    public float t2 = 1.0f;

    IEnumerator P3()
    {
        float rotY = 0.0f;

		float waitTime = 0.5f;


        while (true)
        {
			//少しのずれ
			float latetime = Random.Range(0, waitTime);
			gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
			yield return new WaitForSeconds(latetime);

			rotY += 90.0f;

            if (rotY >= 360)
                rotY = 0.0f;

            gameObject.transform.rotation = Quaternion.Euler(0, rotY, 0);
			gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
			yield return new WaitForSeconds(t1 + waitTime - waitTime);
        }
    }

    void OnEnable()
    {
        cor = StartCoroutine(P3());
    }

    void OnDisable()
    {
        StopCoroutine(cor);
    }
}
