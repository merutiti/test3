using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devile_engiel : MonoBehaviour
{
    public GameObject engel;
    public GameObject devil;
    Vector3 movePosition_eng;　//移動する場所
    Vector3 movePosition_dev;　//移動する場所
    public float speed = 0.0f;
    bool moveButtonJudge = false; //移動中の判定

    public AudioClip migration;//移動したときの効果音
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (moveButtonJudge == false)
        {
            //移動場所設定
            if (Input.GetMouseButtonDown(1))
            {
                audioSource.PlayOneShot(migration);
                movePosition_eng = devil.transform.position;
                movePosition_dev = engel.transform.position;
                moveButtonJudge = true;
            }
            if (moveButtonJudge == true)
            {
            engel.transform.position = Vector3.MoveTowards(engel.transform.position, movePosition_eng, speed);
            devil.transform.position = Vector3.MoveTowards(devil.transform.position, movePosition_dev, speed);
                //移動開始(playerオブジェクトが, 目的地に移動, 移動速度)
            }
        }
        //指定した場所にオブジェクトが移動すると、再度移動が可能になる
        if (engel.transform.position == movePosition_eng&& devil.transform.position == movePosition_dev) moveButtonJudge = false;
    }
}
 

