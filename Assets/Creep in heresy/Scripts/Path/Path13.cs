﻿using UnityEngine;
using System.Collections;

public class Path13 : RootPath
{
    Coroutine cor;

    public float t1 = 1.0f;
    public float t2 = 1.0f;

    IEnumerator P13()
    {
        float waitTime = 0.5f;

        while (true)
        {
            //少しのずれ
            float latetime = Random.Range(0f, waitTime);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(latetime);

            //１本目
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t1);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);

            ActionA();

            //２本目
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            gameObject.GetComponent<NPCObjectMove>().canMoveing = true;
            yield return new WaitForSeconds(t2);

            gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            yield return new WaitForSeconds(1 + waitTime - latetime);

            ActionB();
        }
    }

    void OnEnable()
    {
        cor = StartCoroutine(P13());
    }

    void OnDisable()
    {
        StopCoroutine(cor);
    }
}
