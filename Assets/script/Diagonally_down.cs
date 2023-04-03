using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する
public class Diagonally_down : MonoBehaviour
{

	

	public float speed = 1f; // スピード：Inspectorで指定
	public float speed_x = 1f;
	void Update()
	{
		if (Time.timeScale == 0)
		{
			Destroy(this.gameObject);
		}
	}

	void FixedUpdate()
	{ // ずっと行う（一定時間ごとに）
		this.transform.Translate(speed_x / 50, speed / 50, 0); // 垂直移動する	  
	}
}

