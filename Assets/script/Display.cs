using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] GameObject gameObject;

    void Update()
    {
        //[D]キーを押す
        if (Time.timeScale == 0)
        {
            //ゲームオブジェクト非表示→表示
            gameObject.SetActive(true);
        }
    }
}
