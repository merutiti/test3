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
        //��ɓ��ꂽ��
        if(player_devil.devil_get == true)
        {
            //��ɂ��Ă�����false
            player_devil.devil_get = false;
            transform.localScale = new Vector3(0.125f, 0.125f, 1.5f);
            //�A�j���[�V����true
            anim.SetBool("get_D", true);
            //�A�j���[�V������1��ł���
            Invoke("animD", 0.03f);
        }
    }

    void animD()
    {
        //�A�j���[�V����false
        anim.SetBool("get_D", false);
    }
}
