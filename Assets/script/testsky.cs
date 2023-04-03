using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testsky : MonoBehaviour
{
    //回転スピード
    [Range(0.01f, 0.1f)]
    public float rotateSpeed;

    public Material sky;

    float rotationRepeatValue;

    // Start is called before the first frame update
    void Start()
    {
        rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + rotateSpeed, 360f);

        sky.SetFloat("_Rotation", rotationRepeatValue);

        //キー押してない間はreturn
        if (Input.anyKey == false)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
