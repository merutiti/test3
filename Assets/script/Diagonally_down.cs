using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ƁA�ړ�����
public class Diagonally_down : MonoBehaviour
{

	

	public float speed = 1f; // �X�s�[�h�FInspector�Ŏw��
	public float speed_x = 1f;
	void Update()
	{
		if (Time.timeScale == 0)
		{
			Destroy(this.gameObject);
		}
	}

	void FixedUpdate()
	{ // �����ƍs���i��莞�Ԃ��ƂɁj
		this.transform.Translate(speed_x / 50, speed / 50, 0); // �����ړ�����	  
	}
}

