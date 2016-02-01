/**====================================================================*/
/**
 * プレイヤー１の移動処理
 * 複数のゲームパッドに対応させる
 * 
 * 作成者：守屋
/**====================================================================*/
using UnityEngine;
using System.Collections;

public class Player1Move : Player1
{
	/*==外部設定変数==*/
	//移動速度
	[SerializeField]
	private float m_MoveSpeed = 3.0f;
	//回転速度（進行方向を向く速さ）
	[SerializeField]
	private float m_RotateSpeed = 300;

	/*==内部設定変数==*/
	private Vector3 m_MoveVec = Vector3.zero;

	/*==================*/
	/* 更新   */
	/*==================*/
	void Update ()
	{
		//移動
		float h = MoveUtil.Limit (Input.GetAxis ("Joy" + m_PadNum + "H"));
		float v = MoveUtil.Limit (Input.GetAxis ("Joy" + m_PadNum + "V"));
		m_MoveVec = MoveUtil.CreateMoveVec (h, v);

		GetComponent<Rigidbody>().velocity = m_MoveVec * m_MoveSpeed;
		//tr.position += m_MoveVec * m_MoveSpeed * Time.deltaTime;

		//進行方向を向く
		MoveUtil.LookForward (ref tr, m_MoveVec, m_RotateSpeed);

		GetComponentInChildren<Animator>().SetBool("IsWalking", (h == 0 && v == 0) == false);
	}
}
