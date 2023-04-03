using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する
public class UpForever : MonoBehaviour {

	public float speed = 1; // スピード：Inspectorで指定

    void Update()
    {
        if (Time.timeScale == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate() { // ずっと行う（一定時間ごとに）
		this.transform.Translate(0 ,speed / 50, 0); // 垂直移動する
	}
}

