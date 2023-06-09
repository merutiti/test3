using UnityEngine;
using System.Collections;

public class sky: MonoBehaviour
{
    public float _anglePerFrame = 2.0f;    // 1フレームに何度回すか[unit : deg]
    float _rot = 0.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rot += _anglePerFrame;
        if (_rot >= 360.0f)
        {    // 0〜360°の範囲におさめたい
            _rot -= 360.0f;
        }
        RenderSettings.skybox.SetFloat("_Rotation", _rot);    // 回す
    }
}