using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel_Anima : MonoBehaviour
{
    private Animator anim = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
            transform.localScale = new Vector3(8, 8, 1);
            anim.SetBool("Fly", true);
    }
}
