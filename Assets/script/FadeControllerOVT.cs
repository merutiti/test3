using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //パネルのイメージを操作するのに必要

public class FadeControllerOVT : MonoBehaviour
{
	float fadeSpeed = 0.01f;        //透明度が変わるスピードを管理
	float red, green, blue, alfa;   //パネルの色、不透明度を管理

	public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
	public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ

	Image fadeImage;                //透明度を変更するパネルのイメージ

	[SerializeField] Text colorText;
	void Start()
	{
		/*
		fadeImage = GetComponent<Image>();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;*/
		colorText.color = new Color(255.0f, 255.0f, 0.0f, 0.0f);
		this.gameObject.SetActive(false);//存在を消す
	}

	void Update()
	{
		if (isFadeIn)
		{
			StartFadeIn();
		}


		//暗くする条件
		//ゲームオーバーになったら
		if (Time.timeScale == 0)
		{
			
			if (isFadeOut)
			{
				StartFadeOut();
				
			}
		}
	}

	void StartFadeIn()
	{
		alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
		SetAlpha();                      //b)変更した不透明度パネルに反映する
		if (alfa <= 0)
		{                    //c)完全に透明になったら処理を抜ける
			isFadeIn = false;
			fadeImage.enabled = false;    //d)パネルの表示をオフにする
		}
	}

	//ゲームオーバーのフェード
	void StartFadeOut()
	{
		colorText.color = new Color(255.0f, 255.0f, 0.0f, alfa);

		//fadeImage.enabled = true;  // a)パネルの表示をオンにする
		alfa += fadeSpeed;         // b)不透明度を徐々にあげる
		//SetAlpha();               // c)変更した透明度をパネルに反映する
		if (alfa >= 1.0)
		{             // d)完全に不透明になったら処理を抜ける
			isFadeOut = false;
		}
	}
	void SetAlpha()
	{
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}

