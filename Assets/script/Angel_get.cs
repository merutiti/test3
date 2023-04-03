using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel_get : MonoBehaviour
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
        if (player_engel.angel_get == true)
        {
            player_engel.angel_get = false;
            transform.localScale = new Vector3(0.125f, 0.125f, 1.5f);
            anim.SetBool("get_A", true);
            Invoke("animA", 0.03f);

        }
    }

    void animA()
    {
            //アニメーションfalse
            anim.SetBool("get_A", false);
    }
}
