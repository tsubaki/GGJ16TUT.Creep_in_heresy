/**====================================================================*/
/**
 * プレイヤー１の聖杯を持つ処理
 * 作成者：守屋
/**====================================================================*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player1Attack : Player1
{
    /*==外部設定変数==*/
    //聖杯の個数
    [SerializeField]
    public int m_ChaliceNum = 1;
    //聖杯を持つことができる距離
    [SerializeField]
    private float m_CatchLength = 2.0f;

    /*==内部設定変数==*/
    //聖杯の座標
    private Vector3[] m_ChalicesPos;
    //聖杯を持ったか？
    private bool m_IsCatchChalice = false;

    //聖杯ゲッター
    public bool IsCatchChalice { get { return m_IsCatchChalice; } }

    /*==================*/
    /* 更新前初期化   */
    /*==================*/
    void Start()
    {
        GetChalicesPos();
    }

    /*==================*/
    /* 更新   */
    /*==================*/
    void Update()
    {
        if (m_ChalicesPos == null) return;

        foreach (Vector3 pos in m_ChalicesPos)
        {
            //聖杯を持つことができる距離以内でボタンが押されたら
            if (Vector3.Distance(tr.position, pos) < m_CatchLength)
            {
                GetComponentInChildren<Animator>().SetBool("IsWalking", false);
                GetComponentInChildren<Animator>().SetBool("IsVictory", true);

                GetComponent<Player1Move>().enabled = false;
                GetComponent<Rigidbody>().velocity = Vector3.zero;

                //シーン移行の準備
                if(!m_IsCatchChalice)
                    StartCoroutine(ClearScene());

                m_IsCatchChalice = true;
            }
        }
        
        if (m_IsCatchChalice)
        {
            print("ゴマダレ");
        }
    }

    void GetChalicesPos()
    {        
        //聖杯の位置を取得
        m_ChalicesPos = new Vector3[m_ChaliceNum];
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Chalice");
        if (obj == null) return;
        for (int i = 0; i < m_ChaliceNum; i++)
        {
            m_ChalicesPos[i] = obj[i].transform.position;
        }
    }

    IEnumerator ClearScene()
    {
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene("ChalisSnatched");
    }
}
