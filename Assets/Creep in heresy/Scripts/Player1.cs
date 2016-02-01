/**====================================================================*/
/**
 * プレイヤー１基底クラス
 * 作成者：守屋
/**====================================================================*/
using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{
    /*==所持コンポーネント==*/
    protected Transform tr;
    protected Rigidbody ri;

    /*==外部設定変数==*/
    //パッド番号
    [SerializeField]
    protected int m_PadNum = 1;

    /*==================*/
    /* 生成前初期化   */
    /*==================*/
    protected virtual void Awake()
    {
        //コンポーネント取得
        tr = GetComponent<Transform>();
        ri = GetComponent<Rigidbody>();
    }
}
