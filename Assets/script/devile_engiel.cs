using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devile_engiel : MonoBehaviour
{
    public GameObject engel;
    public GameObject devil;
    Vector3 movePosition_eng;�@//�ړ�����ꏊ
    Vector3 movePosition_dev;�@//�ړ�����ꏊ
    public float speed = 0.0f;
    bool moveButtonJudge = false; //�ړ����̔���

    public AudioClip migration;//�ړ������Ƃ��̌��ʉ�
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (moveButtonJudge == false)
        {
            //�ړ��ꏊ�ݒ�
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
                //�ړ��J�n(player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x)
            }
        }
        //�w�肵���ꏊ�ɃI�u�W�F�N�g���ړ�����ƁA�ēx�ړ����\�ɂȂ�
        if (engel.transform.position == movePosition_eng&& devil.transform.position == movePosition_dev) moveButtonJudge = false;
    }
}
 

