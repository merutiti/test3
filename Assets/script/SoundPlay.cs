using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    //public static bool saisei = false;//条件外し用

    [SerializeField] AudioSource source1;//ゲームのSource
    [SerializeField] AudioSource source2;//オーバーのSource
    [SerializeField] AudioClip clip1;//ゲームBGM入れるとこ
    [SerializeField] AudioClip clip2;//オーバーBGM入れるとこ

    void Start()
    {
        
    }
    void Update()
    {
        /*
        //生きてるなら
        if (Time.timeScale == 1 && saisei == 0)
        {
            //ゲームオーバーBGM止める
            source2.Stop();

            //ゲームBGM再生
            source1.PlayOneShot(clip1);

            //条件でのループ外し用
            saisei = 1;
        }*/

        //死んだなら
        if (Time.timeScale == 0 && player_devil.saisei == true)
        {
            //ゲームBGM止める
            source1.Stop();

            //ゲームオーバーBGM再生
            source2.PlayOneShot(clip2);

            //条件でのループ外し用
            player_devil.saisei = false;
            //source2.Stop();
        }
    }
}
