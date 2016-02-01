/**====================================================================*/
/**
 * プレイヤー２
 * 動きのパターンを変更するボタンの処理
 * 下記のような想定のソースです
 * 0→ランダム移動
 * 1～3→パターン移動
 * 
 * ボタンを押す→数秒間カウントダウン→数秒間パターン実行
 * 
 * 作成者：守屋
/**====================================================================*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PatternButtonCtrl : MonoBehaviour
{
    /*==外部設定変数==*/
    //パターン開始前のカウントダウンにかける時間
    [SerializeField]
    private float m_CountdownRunTime = 5.0f;
    //パターン１回にかける時間 カウントダウン＋これで指定した時間を過ぎるとランダム移動に移行
    [SerializeField]
    private float m_PatternRunTime = 5.0f;
    //ボタンの数
    [SerializeField]
    private int m_ButtonNum = 3;
    //押される前のスプライト
    [SerializeField]
    private Sprite[] m_BeforeSprites;
    //押された後のスプライト
    [SerializeField]
    private Sprite[] m_AfterSprites;

    /*==内部設定変数==*/
    //選ばれたパターンの番号　0だとランダム移動
    private int m_SelectedPatternNum = 0;
    //パターン実行のカウントダウン中か？
    private bool m_IsCountdown = false;
    //パターンを実行中か？
    private bool m_IsRunning = false;
    //Buttonオブジェクト
    private GameObject[] m_Buttons;
    //SceneManagerオブジェクト
    private GameObject m_SceneManager;

    /*==================*/
    /* 更新前初期化   */
    /*==================*/
    void Start()
    {
        //オブジェクト取得
        m_Buttons = GameObject.FindGameObjectsWithTag("PatternButton");
/*        for (int i = 0; i < m_ButtonNum; i++)
        {
            //スプライトをセット
            m_Buttons[i].GetComponent<Image>().sprite = m_BeforeSprites[i];
        }*/
        m_SceneManager = GameObject.FindGameObjectWithTag("StageManager");

		Debug.Assert(m_SceneManager != null);
    }

    /*==================*/
    /* 更新処理   */
    /*==================*/
    void Update()
    {

    }

    /// <summary>
    /// カウントダウン状態かどうかを返す
    /// </summary>
    public bool IsCountdown()
    {
        return m_IsCountdown;
    }
    /// <summary>
    /// パターン実行中かどうかを返す
    /// </summary>
    public bool IsRunning()
    {
        return m_IsRunning;
    }

    /// <summary>
    /// 実行中のパターンの番号を返す
    /// 実行中でない場合は0（ランダム移動）を返す
    /// </summary>
    /// <returns></returns>
    public int GetRunningPattern()
    {
        if (m_IsRunning || m_IsCountdown) return m_SelectedPatternNum;
        return 0;
    }

    /// <summary>
    /// UIボタンから入力
    /// パターンを選択して実行する
    /// </summary>
    public void SetPatternNum(int num)
    {
        //他のパターンを実行中の場合は入力を受け付けない
        if (m_IsCountdown || m_IsRunning) return;

        //番号をセット
        m_SelectedPatternNum = num;
        //スプライトを差し替える
        //m_Buttons[num - 1].GetComponent<Image>().sprite = m_AfterSprites[num - 1];
        //実行
        m_IsCountdown = true;
        StartCoroutine(CountdownRun());
    }

    /// <summary>
    /// カウントダウンを実行
    /// </summary>
    IEnumerator CountdownRun()
    {
        float timer = 0.0f;

        while (true)
        {
            timer += Time.deltaTime;
            print("Countdown:" + (m_CountdownRunTime - timer));
            if (timer > m_CountdownRunTime)
            {
                print("Countdown_end");
                //パターン実行
                m_IsCountdown = false;
                m_IsRunning = true;
                //パスを送って実際にパターンを実行させる
                SendPathType();
                yield return StartCoroutine(PatternRun());
                yield break;
            }
            yield return null;
        }
    }

    /// <summary>
    /// パターンを実行
    /// </summary>
    IEnumerator PatternRun()
    {
        float timer = 0.0f;

        while (true)
        {
            timer += Time.deltaTime;

            if (timer > m_PatternRunTime)
            {
                print("Pattern_end");
                //スプライトを元に戻す
                //m_Buttons[m_SelectedPatternNum - 1].GetComponent<Image>().sprite = m_BeforeSprites[m_SelectedPatternNum - 1];
                //ランダム状態に戻し、コルーチンを終了
                m_SelectedPatternNum = 0;
                m_IsRunning = false;
                SendPathType();
                yield break;
            }
            yield return null;
        }
    }

    /// <summary>
    /// パターン番号をPatyTypeに変えて、ステージマネージャーにセット
    /// </summary>
    void SendPathType()
    {
        StageManeTest.PathType t;
        if (m_SelectedPatternNum == 1) t = StageManeTest.PathType.Path01;
        else if (m_SelectedPatternNum == 2) t = StageManeTest.PathType.Path02;
        else if (m_SelectedPatternNum == 3) t = StageManeTest.PathType.Path03;
        else t = StageManeTest.PathType.RandomMove;

        m_SceneManager.GetComponent<StageManeTest>().SetPathType(t);
    }

    //　田中が付け足した関数
    public void SetBeforeSprite(int num)
    {
        m_Buttons[num - 1].GetComponent<Image>().sprite = m_BeforeSprites[num - 1];
    }

    public void SetAfterSprite(int num)
    {
        m_Buttons[num - 1].GetComponent<Image>().sprite = m_AfterSprites[num - 1];
    }
}
