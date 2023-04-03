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
        //�v���C���[���玝���Ă���
        if (player_devil.devil_Dead == true)
        {
            transform.localScale = new Vector3(0.125f, 0.125f, 1.5f);
            //�A�j���[�V����true
            anim.SetBool("Dead", true);
            //��ɂ��Ă�����false
            player_devil.devil_get = false;
            devil0 = true;
        }
        //�����߂�
        Invoke("De", 0.1f);
    }
    void De()
    {
        if (Time.timeScale == 1)
        {
            //�A�j���[�V����false
            anim.SetBool("Dead", false);
        }

    }

}