using UnityEngine;
using System.Collections;

public class RandomMove : RootPath
{
    public GameObject[] point = new GameObject[4];

    Coroutine cor;

    void Start()
    {
        for(int i = 0; i < point.Length; i++) point[i] = GameObject.Find("Points/point" + i);
    }

    IEnumerator RandPattern()
    {
        gameObject.GetComponent<NPCObjectMove>().canMoveing = true;

        while (true)
        {
            int n = Random.Range(0, 7);
            float t = Random.Range(2f, 4f);
            int p = Random.Range(0, point.Length);

            int stop = Random.Range(0, 4);

            if(stop == 1)
                gameObject.GetComponent<NPCObjectMove>().canMoveing = false;
            else
                gameObject.GetComponent<NPCObjectMove>().canMoveing = true;

            Vector3 targetVec = new Vector3(point[p].transform.position.x, gameObject.transform.position.y, point[p].transform.position.z);
            gameObject.transform.LookAt(targetVec);
            gameObject.transform.rotation = Quaternion.Euler(0, 45 * Mathf.FloorToInt(gameObject.transform.rotation.eulerAngles.y / 45), 0);
            yield return new WaitForSeconds(t);
            
            //switch (s)
            //{
            //    //ランダムに方向転換
            //    case 0:
            //        {
            //            gameObject.transform.rotation = Quaternion.Euler(0, 45 * n, 0);
            //            yield return new WaitForSeconds(t);

            //            break;
            //        }
        }
    }

    void OnEnable()
    {
        cor = StartCoroutine(RandPattern());
    }

    void OnDisable()
    {
        StopCoroutine(cor);
    }
}
