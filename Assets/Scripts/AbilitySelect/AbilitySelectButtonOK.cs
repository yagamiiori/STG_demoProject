﻿using UnityEngine;
using System.Collections;

public class AbilitySelectButtonOK : MonoBehaviour
{
    private GameManager gameManager;                    // マネージャコンポ
    private string nextScene = "Lobby";                 // スタートボタンプッシュ時遷移先シーン
    private int isStarted = 0;                          // スタートボタンプッシュ判定フラグ
    
	void Start ()
    {
        // マネージャコンポ取得
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}
    
    // -------------------------------
    // OKボタンクリック判定メソッド（ユニットセレクトシーン）
    // ユニットセレクトシーンにてOKボタンが押された場合（ユニット確定した場合）にコールされ
    // 選択したユニットをユニットリストに格納、アビリティシステム有無フラグを確認し
    // アビリティセレクトシーンまたはポジションセレクトシーンに遷移する。
    // -------------------------------
    public void OnClick()
    {
        // スタートボタン未プッシュの場合
        if (0 == isStarted)
        {
            // スタートボタンプッシュ判定フラグをONにしてスタートボタンプッシュ後に
            // オプションが変更されたりスタートボタン連打を抑止する。
            isStarted = 1;

            // Scene遷移実施（アビリティセレクトへ）
            // ﾌｪｰﾄﾞｱｳﾄ時間、ﾌｪｰﾄﾞ中待機時間、ﾌｪｰﾄﾞｲﾝ時間、ｶﾗｰ、遷移先Pos情報(Vector3)、遷移先ｼｰﾝ
            gameManager.GetComponent<FadeToScene>().FadeOut(0.1f, 0.6f, 0.1f, Color.black, nextScene);
        }
    }
}
