using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public GameObject player_engel;   //(����)�ړ��������I�u�W�F�N�g��ݒ�
    Vector3 movePosition_engel;�@//�ړ����鋗�����i�[
    public int speed_engel = 5;�@//1�}�X���Ɉړ�����X�s�[�h
    public Vector3 moveX_engel = new Vector3(1, 0, 0);�@//(1�}�X����)X���̈ړ�����
    bool moveButtonJudge_engel = false; //�ړ����̔���

    void Start()
    {

    }

    void Update()
    {
        //�ړ��ꏊ�ݒ�
        //�L�[���͂��s���ƁAmoveButtonJudge = true �ɕς��A�ꎞ�I�ɃL�[���͂𖳌�
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
            player_engel.transform.position = Vector3.MoveTowards(player_engel.transform.position, movePosition_engel, speed_engel * Time.deltaTime);   //�ړ��J�n(player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x)
        }
        //�w�肵���ꏊ�ɃI�u�W�F�N�g���ړ�����ƁA�ēx�ړ����\�ɂȂ�
        if (player_engel.transform.position == movePosition_engel) moveButtonJudge_engel = false;
    }
}