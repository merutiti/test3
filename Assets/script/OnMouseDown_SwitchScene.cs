using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	// シーン切り替えに必要

// タッチすると、シーンを切り換える
public class OnMouseDown_SwitchScene : MonoBehaviour {

	public string sceneName;  // シーン名：Inspectorで指定

	public AudioClip scenese;
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		Screen.SetResolution(1024, 576, false);
		Application.targetFrameRate = 30;
	}

	public void PushButton () { // タッチしたら
		audioSource.PlayOneShot(scenese);
		Time.timeScale = 1;//ゲームオーバーじゃなくす
		// シーンを切り換える
		SceneManager.LoadScene (sceneName);
		Debug.Log("aaa");
	}
}
