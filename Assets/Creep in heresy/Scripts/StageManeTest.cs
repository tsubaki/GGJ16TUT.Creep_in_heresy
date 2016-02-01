using UnityEngine;
using System.Collections;

public class StageManeTest : MonoBehaviour {

    public enum PathType
    {
        Path01 = 1,
        Path02,
        Path03,
		Path04,
		Path05,
		Path06,
		Path07,
		Path08,
		Path09,
		Path10,
		Path11,
		Path12,
		Path13,
		Path14,
		Path15,
        RandomMove = 0
    }

    public PathType pathType;

    [SerializeField]
    NPCObjectMove[] npcObjects;

    const int pathMaxNum = 15;
    int[] randPathNumbers = new int[3];

    void Start()
    {
        npcObjects = FindObjectsOfType<NPCObjectMove>();

        for (int i = 0; i < randPathNumbers.Length; i++)
            randPathNumbers[i] = -1;

        int pathIndexCount = 0;
        while(true)
        {
            bool flag = false;
            int randint = Random.Range(1, pathMaxNum);

            for(int i = 0; i < randPathNumbers.Length; i++)
            {
                if(randPathNumbers[i] == randint)
                {
                    flag = true;
                    break;
                }
            }

            if(!flag)
            {
                randPathNumbers[pathIndexCount] = randint;
                pathIndexCount++;
            }

            if (pathIndexCount >= randPathNumbers.Length)
                break;
        }

        Debug.Log(randPathNumbers[0]);
        Debug.Log(randPathNumbers[1]);
        Debug.Log(randPathNumbers[2]);
    }

    void OnValidate()
    {
        npcObjects = FindObjectsOfType<NPCObjectMove>();

		SetPathNumbers((int)pathType);
    }

    void SetPathNumbers(int pathIndex)
    {
        switch(pathIndex)
        {
            case 1:
                SetPath1();
                break;
            case 2:
                SetPath2();
                break;
            case 3:
                SetPath3();
                break;
                
            case 4:
                SetPath4();
                break;
            case 5:
                SetPath5();
                break;
            case 6:
                SetPath6();
                break;

            case 7:
                SetPath7();
                break;
            case 8:
                SetPath8();
                break;
            case 9:
                SetPath9();
                break;

            case 10:
                SetPath10();
                break;
            case 11:
                SetPath11();
                break;
            case 12:
                SetPath12();
                break;

            case 13:
                SetPath13();
                break;
            case 14:
                SetPath14();
                break;
            case 15:
                SetPath15();
                break;

            default:
                SetRandomMove();
                break;
        }
    }

    public void SetPath1()
    {
        foreach( var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path01)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath2()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path02)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath3()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path03)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath4()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path04)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath5()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path05)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath6()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path06)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath7()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path07)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath8()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path08)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath9()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path09)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath10()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path10)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath11()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path11)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath12()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path12)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath13()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path13)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath14()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path14)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetPath15()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is Path15)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }

    public void SetRandomMove()
    {
        foreach (var npc in npcObjects)
        {
            var paths = npc.GetComponents<RootPath>();
            foreach (var pathComponent in paths)
            {
                if (pathComponent is RandomMove)
                {
                    pathComponent.enabled = true;
                }
                else
                    pathComponent.enabled = false;
            }
        }
    }


    /// <summary>
    /// パスをセットする
    /// </summary>
    public void SetPathType(PathType type)
    {
        switch (type)
        {
            case PathType.Path01:
                SetPathNumbers(randPathNumbers[0]);
                break;
            case PathType.Path02:
                SetPathNumbers(randPathNumbers[1]);
                break;
            case PathType.Path03:
                SetPathNumbers(randPathNumbers[2]);
                break;
            default:
                SetRandomMove();
                break;

        }
    }
}
