/**====================================================================*/
/**
 * 移動の計算を楽にする関数群
 * 
 * 作成者：守屋
/**====================================================================*/
using UnityEngine;
using System.Collections;

public static class MoveUtil
{
    //入力されたゲームパッドからの数値を-1or0or1に制限
    public static float Limit(float val)
    {
        float result = 0;
        if (val < 0) result = -1.0f;
        else if (val > 0) result = 1.0f;
        return result;
    }

    //水平方向成分と垂直方向成分を受け取って、x,z軸方向の移動ベクトルを作る
    public static Vector3 CreateMoveVec(float h, float v)
    { 
        return new Vector3(h, 0, v).normalized;
    }

    /// <summary>
    /// 進行方向を向かせる
    /// </summary>
    /// <param name="t">進行方向を向かせたいTransformコンポーネント</param>
    /// <param name="vec">正規化した進行方向</param>
    /// <param name="rotSpeed">向きを変えるスピード</param>
    public static void LookForward(ref Transform t, Vector3 vec, float rotSpeed)
    {
        if (vec != Vector3.zero)
        {
            Quaternion q = Quaternion.LookRotation(vec);
            t.rotation = Quaternion.RotateTowards(t.rotation, q, rotSpeed * Time.deltaTime);
        }
    }
}
