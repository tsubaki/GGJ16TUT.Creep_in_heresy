using UnityEngine;
using System.Collections;

public class Path09 : RootPath
{
    Coroutine cor;

    public float t1 = 1.0f;     //たて
    public float t2 = 1.0f;     //よこ
    public float t3 = 1.5f;     //ななめ

    IEnumerator P9()
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

            //２本目
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t2);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);

            //３本目
            gameObject.transform.rotation = Quaternion.Euler(0, -45, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t3);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);
        }
    }

    void OnEnable()
    {
        cor = StartCoroutine(P9());
    }

    void OnDisable()
    {
        StopCoroutine(cor);
    }
}
