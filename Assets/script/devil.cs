using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devil : MonoBehaviour
{
    public GameObject player;   //(����)�ړ��������I�u�W�F�N�g��ݒ�
    Vector3 movePosition;�@//�ړ����鋗�����i�[
    public int speed = 5;�@//1�}�X���Ɉړ�����X�s�[�h
    public Vector3 moveX = new Vector3(1, 0, 0);�@//(1�}�X����)X���̈ړ�����
    bool moveButtonJudge=false; //�ړ����̔���

    void Start()
    {

    }

    void Update()
    {
        //�ړ��ꏊ�ݒ�
        //�L�[���͂��s���ƁAmoveButtonJudge = true �ɕς��A�ꎞ�I�ɃL�[���͂𖳌�
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
            player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, speed * Time.deltaTime);   //�ړ��J�n(player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x)
        }
        //�w�肵���ꏊ�ɃI�u�W�F�N�g���ړ�����ƁA�ēx�ړ����\�ɂȂ�
        if (player.transform.position == movePosition) moveButtonJudge = false;
    }
}