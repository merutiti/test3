using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_devil : MonoBehaviour
{
   public int score = 0;

    public static bool saisei = false;//�T�E���h�����O���p

    public AudioClip correct;//�����Ă�����
    public AudioClip death;//�Ԉ�����Ƃ�
    AudioSource audioSource;

    public Text text;
    public Text text2;

    private Animator anim = null;

    public static bool devil_get;//�Q�b�g�G�t�F�N�g
    public static bool devil_Dead;//�f�X�G�t�F�N�g

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        devil_get = false;
        devil_Dead = false;
    }

    // �Q�[���I�u�W�F�N�g���m���ڐG�����^�C�~���O�Ŏ��s
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "orange")
        {
            audioSource.PlayOneShot(correct);
            score++;
            Destroy(col.gameObject);
            text.text = score.ToString();
            text2.text = score.ToString();
            //getanima
            devil_get = true;
        }
        //�Ԉ�����ꍇ
        if(col.gameObject.tag=="green")
        {
            devil_Dead = true;//�A�j���[�V�����p
            audioSource.PlayOneShot(death);
            Invoke("devil_delay", 0.3f);//0.3�b�㓮����
            Destroy(col.gameObject);
            //SoundPlayer��saisei�������Ă���
            saisei = true;
        }
    }

    void devil_delay()
    {
            Time.timeScale = 0;
    }
}
