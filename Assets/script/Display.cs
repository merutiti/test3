using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] GameObject gameObject;

    void Update()
    {
        //[D]�L�[������
        if (Time.timeScale == 0)
        {
            //�Q�[���I�u�W�F�N�g��\�����\��
            gameObject.SetActive(true);
        }
    }
}
