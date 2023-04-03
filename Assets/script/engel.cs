using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public GameObject player_engel;   //(操作)移動したいオブジェクトを設定
    Vector3 movePosition_engel;　//移動する距離を格納
    public int speed_engel = 5;　//1マス毎に移動するスピード
    public Vector3 moveX_engel = new Vector3(1, 0, 0);　//(1マス毎の)X軸の移動距離
    bool moveButtonJudge_engel = false; //移動中の判定

    void Start()
    {

    }

    void Update()
    {
        //移動場所設定
        //キー入力を行うと、moveButtonJudge = true に変わり、一時的にキー入力を無効
        if (moveButtonJudge_engel == false)
        {

            if (Input.GetKeyDown("d"))
            {
                movePosition_engel = player_engel.transform.position + moveX_engel;
                moveButtonJudge_engel = true;
            }
            if (Input.GetKeyDown("a"))
            {
                movePosition_engel = player_engel.transform.position + -moveX_engel;
                moveButtonJudge_engel = true;
            }
        }
        if (moveButtonJudge_engel == true)
        {
            player_engel.transform.position = Vector3.MoveTowards(player_engel.transform.position, movePosition_engel, speed_engel * Time.deltaTime);   //移動開始(playerオブジェクトが, 目的地に移動, 移動速度)
        }
        //指定した場所にオブジェクトが移動すると、再度移動が可能になる
        if (player_engel.transform.position == movePosition_engel) moveButtonJudge_engel = false;
    }
}