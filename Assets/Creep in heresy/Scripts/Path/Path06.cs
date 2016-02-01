using UnityEngine;
using System.Collections;

public class Path06 : RootPath
{
    Coroutine cor;

    public float t1 = 1.0f;
    public float t2 = 1.0f;

    IEnumerator P6()
    {
        float waitTime = 0.5f;

        while (true)
        {
            //少しのずれ
            float latetime = Random.Range(0f, waitTime);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(latetime);

            //１本目
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t1);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);

            ActionA();
            ActionB();

            //２本目
            gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t2);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);

            ActionA();
            ActionB();
        }
    }

    void OnEnable()
    {
        cor = StartCoroutine(P6());
    }

    void OnDisable()
    {
        StopCoroutine(cor);
    }
}
