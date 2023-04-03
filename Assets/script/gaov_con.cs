using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaov_con : MonoBehaviour
{
    private float speed;
    public Transform target;
    public float x = 0.0f;
    public float y = 0.0f;
   
    void Start()
    {
        speed = 0.1f;
       
    }

    void Update()
    {
        if (Time.timeScale==0) {
            target.transform.position = new Vector3(x, y, 0.0f);
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed);

        }
    }
}
