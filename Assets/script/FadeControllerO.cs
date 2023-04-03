using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //�p�l���̃C���[�W�𑀍삷��̂ɕK�v

public class FadeControllerO : MonoBehaviour
{
	float fadeSpeed = 0.001f;        //�����x���ς��X�s�[�h���Ǘ�
	float red, green, blue, alfa;   //�p�l���̐F�A�s�����x���Ǘ�

	public bool isFadeOut = false;  //�t�F�[�h�A�E�g�����̊J�n�A�������Ǘ�����t���O
	public bool isFadeIn = false;   //�t�F�[�h�C�������̊J�n�A�������Ǘ�����t���O

	Image fadeImage;                //�����x��ύX����p�l���̃C���[�W

	void Start()
	{
		fadeImage = GetComponent<Image>();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;
		this.gameObject.SetActive(false);//���݂�����
	}

	void Update()
	{
		if (isFadeIn)
		{
			StartFadeIn();
		}


		//�Â��������
		//�Q�[���I�[�o�[�ɂȂ�����
		if (Time.timeScale == 0) {
			if (isFadeOut)
			{
				StartFadeOut();
			}
		}
	}

	void StartFadeIn()
	{
		alfa -= fadeSpeed;                //a)�s�����x�����X�ɉ�����
		SetAlpha();                      //b)�ύX�����s�����x�p�l���ɔ��f����
		if (alfa <= 0)
		{                    //c)���S�ɓ����ɂȂ����珈���𔲂���
			isFadeIn = false;
			fadeImage.enabled = false;    //d)�p�l���̕\�����I�t�ɂ���
		}
	}
	
	//�Q�[���I�[�o�[�̃t�F�[�h
	void StartFadeOut()
	{
		fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
		alfa += fadeSpeed;         // b)�s�����x�����X�ɂ�����
		SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
		if (alfa >= 1.0)
		{             // d)���S�ɕs�����ɂȂ����珈���𔲂���
			isFadeOut = false;
		}
	}
	void SetAlpha()
	{
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
