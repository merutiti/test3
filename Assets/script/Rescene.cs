using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン切り替えに必要

// タッチすると、シーンを切り換える
public class Rescene : MonoBehaviour
{
	public void PushButton()
	{ // タッチしたら
			Time.timeScale = 1;//ゲームオーバーじゃなくす
	  // 現在のSceneを取得
		Scene loadScene = SceneManager.GetActiveScene();
		// 現在のシーンを再読み込みする
		SceneManager.LoadScene(loadScene.name);
	}
}
