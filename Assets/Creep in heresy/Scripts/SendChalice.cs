using UnityEngine;
using System.Collections;

public class SendChalice : MonoBehaviour {
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.CompareTag("Player1"))
        {
            if (col.gameObject.GetComponent<Player1Attack>().IsCatchChalice)
                gameObject.transform.position = col.gameObject.transform.position + new Vector3( 0, 5.0f, 0.0f);
        }
    }
}
