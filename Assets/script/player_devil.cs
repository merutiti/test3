using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_devil : MonoBehaviour
{
   public int score = 0;

    public static bool saisei = false;//サウンド条件外し用

    public AudioClip correct;//合っていた時
    public AudioClip death;//間違ったとき
    AudioSource audioSource;

    public Text text;
    public Text text2;

    private Animator anim = null;

    public static bool devil_get;//ゲットエフェクト
    public static bool devil_Dead;//デスエフェクト

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        devil_get = false;
        devil_Dead = false;
    }

    // ゲームオブジェクト同士が接触したタイミングで実行
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "orange")
        {
            audioSource.PlayOneShot(correct);
            score++;
            Destroy(col.gameObject);
            text.text = score.ToString();
            text2.text = score.ToString();
            //getanima
            devil_get = true;
        }
        //間違った場合
        if(col.gameObject.tag=="green")
        {
            devil_Dead = true;//アニメーション用
            audioSource.PlayOneShot(death);
            Invoke("devil_delay", 0.3f);//0.3秒後動かす
            Destroy(col.gameObject);
            //SoundPlayerのsaiseiを持ってくる
            saisei = true;
        }
    }

    void devil_delay()
    {
            Time.timeScale = 0;
    }
}
