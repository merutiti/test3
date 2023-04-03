using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil_get : MonoBehaviour
{
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //手に入れたら
        if(player_devil.devil_get == true)
        {
            //手にいてた判定false
            player_devil.devil_get = false;
            transform.localScale = new Vector3(0.125f, 0.125f, 1.5f);
            //アニメーションtrue
            anim.SetBool("get_D", true);
            //アニメーションが1回でたら
            Invoke("animD", 0.03f);
        }
    }

    void animD()
    {
        //アニメーションfalse
        anim.SetBool("get_D", false);
    }
}
