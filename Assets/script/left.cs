using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ƁA�ړ�����
public class left : MonoBehaviour
{

	public float speed = 1; // �X�s�[�h�FInspector�Ŏw��
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
	{ // �����ƍs���i��莞�Ԃ��ƂɁj
		this.transform.Translate(speed/50, 0, 0); // �����ړ�����
	}
}

