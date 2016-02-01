using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;


public class RootPath : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    int waitTime;
    public enum Direction
    {
        LeftDown = 1,
        CenterDown,
        RightDown,
        LeftMiddle,
        CenterMiddle,
        RightMiddle,
        LeftUp,
        CenterUp,
        RightUp
    }

    //アクションA
    public void ActionA()
    {
        Debug.Log("ActionA");
        StartCoroutine (WaitTime());
    }

    //アクションB
    public void ActionB()
    {
        Debug.Log("ActionB");
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
