using UnityEngine;
using System.Collections;

public class Player1StartSpawn : MonoBehaviour {

    public float spawnXMin = -10.0f;
    public float spawnXMax = 10.0f;

    public float spawnZMin = 0.0f;
    public float spawnZMax = -10.0f;
    
    // Use this for initialization
    void Start () {
        Respawn();
    }

    //再配置
    void Respawn()
    {
        gameObject.transform.position = new Vector3(Random.Range(spawnXMin, spawnXMax), gameObject.transform.position.y, Random.Range(spawnZMin, spawnZMax));
    }
}
