using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devil : MonoBehaviour
{
    public GameObject player;   //(操作)移動したいオブジェクトを設定
    Vector3 movePosition;　//移動する距離を格納
    public int speed = 5;　//1マス毎に移動するスピード
    public Vector3 moveX = new Vector3(1, 0, 0);　//(1マス毎の)X軸の移動距離
    bool moveButtonJudge=false; //移動中の判定

    void Start()
    {

    }

    void Update()
    {
        //移動場所設定
        //キー入力を行うと、moveButtonJudge = true に変わり、一時的にキー入力を無効
        if (moveButtonJudge == false)
        {
           
            if (Input.GetKeyDown("right"))
            {
                movePosition = player.transform.position + moveX;
                moveButtonJudge = true;
            }
            if (Input.GetKeyDown("left"))
            {
                movePosition = player.transform.position + -moveX;
                moveButtonJudge = true;
            }
        }
        if (moveButtonJudge == true)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, speed * Time.deltaTime);   //移動開始(playerオブジェクトが, 目的地に移動, 移動速度)
        }
        //指定した場所にオブジェクトが移動すると、再度移動が可能になる
        if (player.transform.position == movePosition) moveButtonJudge = false;
    }
}