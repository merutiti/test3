using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Anima : MonoBehaviour
{
    public static bool devil0 = false;

    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーから持ってくる
        if (player_devil.devil_Dead == true)
        {
            transform.localScale = new Vector3(0.125f, 0.125f, 1.5f);
            //アニメーションtrue
            anim.SetBool("Dead", true);
            //手にいてた判定false
            player_devil.devil_get = false;
            devil0 = true;
        }
        //条件戻る
        Invoke("De", 0.1f);
    }
    void De()
    {
        if (Time.timeScale == 1)
        {
            //アニメーションfalse
            anim.SetBool("Dead", false);
        }

    }

}