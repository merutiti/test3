using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    //public static bool saisei = false;//�����O���p

    [SerializeField] AudioSource source1;//�Q�[����Source
    [SerializeField] AudioSource source2;//�I�[�o�[��Source
    [SerializeField] AudioClip clip1;//�Q�[��BGM�����Ƃ�
    [SerializeField] AudioClip clip2;//�I�[�o�[BGM�����Ƃ�

    void Start()
    {
        
    }
    void Update()
    {
        /*
        //�����Ă�Ȃ�
        if (Time.timeScale == 1 && saisei == 0)
        {
            //�Q�[���I�[�o�[BGM�~�߂�
            source2.Stop();

            //�Q�[��BGM�Đ�
            source1.PlayOneShot(clip1);

            //�����ł̃��[�v�O���p
            saisei = 1;
        }*/

        //���񂾂Ȃ�
        if (Time.timeScale == 0 && player_devil.saisei == true)
        {
            //�Q�[��BGM�~�߂�
            source1.Stop();

            //�Q�[���I�[�o�[BGM�Đ�
            source2.PlayOneShot(clip2);

            //�����ł̃��[�v�O���p
            player_devil.saisei = false;
            //source2.Stop();
        }
    }
}
